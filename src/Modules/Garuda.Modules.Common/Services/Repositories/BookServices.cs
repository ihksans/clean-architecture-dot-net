// <copyright file="BookServices.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Garuda.Abstract.Contracts;
using Garuda.Infrastructure.Exceptions;
using Garuda.Modules.Common.Constants;
using Garuda.Modules.Common.Dtos;
using Garuda.Modules.Common.Dtos.Requests.Book;
using Garuda.Modules.Common.Dtos.Responses;
using Garuda.Modules.Common.Models.Contracts;
using Garuda.Modules.Common.Models.Datas;
using Garuda.Modules.Common.Services.Contracts;
using Microsoft.Extensions.Logging;

namespace Garuda.Modules.Common.Services.Repositories
{
    public class BookServices : IBookService
    {
        private readonly IStorage _iStorage;
        private readonly ILogger _iLogger;
        private readonly IMapper _iMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookServices"/> class.
        /// </summary>
        /// <param name="iStorage"></param>
        /// <param name="iLogger"></param>
        /// <param name="iMapper"></param>
        public BookServices(
           IStorage iStorage,
           ILogger<BookServices> iLogger,
           IMapper iMapper)
        {
            _iStorage = iStorage;
            _iLogger = iLogger;
            _iMapper = iMapper;
        }

        public async Task<(SuccessTransactDto, HttpResponseLibraryException)> CreateData(BookCreateRequest model)
        {
            try
            {
                var mapRequest = _iMapper.Map<BookCreateRequest, Book>(model);
                _iLogger.LogInformation("Trying to create book data..");

                var data = await _iStorage.GetRepository<IBookRepository>().AddData(mapRequest);
                await _iStorage.SaveAsync();
                _iLogger.LogInformation($"Data has been saved. with id {data.Id} ");
                var map = _iMapper.Map<Book, BookResponse>(data);
                return (new SuccessTransactDto(SuccessConstant.BOOK_CREATED, map), null);
            }
            catch (Exception ex)
            {
                _iLogger.LogInformation($"Failed to created book, err : {ex}");
                return (null, ErrorConstant.SOMETHING_WRONG);
            }
        }

        public async Task<(SuccessTransactDto, HttpResponseLibraryException)> DeleteDataById(Guid id)
        {
            try
            {
                _iLogger.LogInformation($"Trying to deleting book data with id: {id}");
                var data = await _iStorage.GetRepository<IBookRepository>().DeleteById(id);
                if (data == null)
                {
                    _iLogger.LogInformation($"Data not found with id: {id}");
                    return (null, ErrorConstant.NOT_FOUND_BOOKS);
                }

                await _iStorage.SaveAsync();
                var map = _iMapper.Map<Book, BookResponse>(data);
                _iLogger.LogInformation($"Data has been deleting. with id: {map.Id}");
                return (new SuccessTransactDto(SuccessConstant.BOOK_DELETED, map), null);
            }
            catch (Exception ex)
            {
                _iLogger.LogInformation($"Failed to deleted book, err : {ex}");
                return (null, ErrorConstant.SOMETHING_WRONG);
            }
        }

        public async Task<(SuccessTransactDto, HttpResponseLibraryException)> GetAllData()
        {
            try
            {
                _iLogger.LogInformation("Trying to fetching book data..");

                var datas = await _iStorage.GetRepository<IBookRepository>().GetList();
                _iLogger.LogInformation($"Data has been fetch. with length {datas.Count} data");
                if (datas.Count > 0)
                {
                    List<BookResponse> books = new List<BookResponse> { };
                    foreach (var data in datas)
                    {
                        var map = _iMapper.Map<Book, BookResponse>(data);
                        books.Add(map);
                    }

                    return (new SuccessTransactDto(SuccessConstant.FOUND_BOOKS, books), null);
                }

                return (null, ErrorConstant.NOT_FOUND_BOOKS);
            }
            catch (Exception ex)
            {
                _iLogger.LogInformation($"Failed to fetching book, err : {ex}");
                return (null, ErrorConstant.SOMETHING_WRONG);
            }
        }

        public async Task<(SuccessTransactDto, HttpResponseLibraryException)> GetDataById(Guid id)
        {
            try
            {
                _iLogger.LogInformation($"Trying to fetching book data with id: {id}");
                var data = await _iStorage.GetRepository<IBookRepository>().GetById(id);
                if (data == null)
                {
                    _iLogger.LogInformation($"Data not found with id: {id}");
                    return (null, ErrorConstant.NOT_FOUND_BOOKS);
                }

                var map = _iMapper.Map<Book, BookResponse>(data);
                _iLogger.LogInformation($"Data has been fetch. with id: {map.Id}");
                return (new SuccessTransactDto(SuccessConstant.FOUND_BOOKS, map), null);
            }
            catch (Exception ex)
            {
                _iLogger.LogInformation($"Failed to fetching book, err : {ex}");
                return (null, ErrorConstant.SOMETHING_WRONG);
            }
        }

        public async Task<(SuccessTransactDto, HttpResponseLibraryException)> UpdateData(BookUpdateRequest model)
        {
            try
            {
                var mapRequest = _iMapper.Map<BookUpdateRequest, Book>(model);
                _iLogger.LogInformation("Trying to update book data..");

                var data = await _iStorage.GetRepository<IBookRepository>().UpdateData(mapRequest);
                if (data == null)
                {
                    _iLogger.LogInformation($"Data not found with id: {model.Id}");
                    return (null, ErrorConstant.NOT_FOUND_BOOKS);
                }

                await _iStorage.SaveAsync();

                _iLogger.LogInformation($"Data has been updating. with id {data.Id} ");
                var map = _iMapper.Map<Book, BookResponse>(data);
                return (new SuccessTransactDto(SuccessConstant.BOOK_UPDATED, map), null);
            }
            catch (Exception ex)
            {
                _iLogger.LogInformation($"Failed to created book, err : {ex}");
                return (null, ErrorConstant.SOMETHING_WRONG);
            }
        }
    }
}
