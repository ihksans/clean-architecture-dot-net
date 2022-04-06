// <copyright file="IBookService.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Garuda.Infrastructure.Exceptions;
using Garuda.Modules.Common.Dtos;
using Garuda.Modules.Common.Dtos.Requests.Book;
using Garuda.Modules.Common.Dtos.Responses;

namespace Garuda.Modules.Common.Services.Contracts
{
    /// <summary>
    /// Book services contract
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// Create Book Data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        Task<(SuccessTransactDto, HttpResponseLibraryException)> CreateData(BookCreateRequest model);

        /// <summary>
        /// Get All Book Data
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        Task<(SuccessTransactDto, HttpResponseLibraryException)> GetAllData();

        /// <summary>
        /// Get Book Data by Id
        /// </summary>
        /// <param name="id"> A Book Id</param>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        Task<(SuccessTransactDto, HttpResponseLibraryException)> GetDataById(Guid id);

        /// <summary>
        /// Update Current Book Data
        /// </summary>
        /// <param name="model"> A Book Id</param>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        Task<(SuccessTransactDto, HttpResponseLibraryException)> UpdateData(BookUpdateRequest model);

        /// <summary>
        /// Delete Current Book Data
        /// </summary>
        /// <param name="id"> A Book Id</param>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        Task<(SuccessTransactDto, HttpResponseLibraryException)> DeleteDataById(Guid id);
    }
}
