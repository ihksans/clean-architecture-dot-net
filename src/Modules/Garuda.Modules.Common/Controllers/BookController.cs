// <copyright file="BookController.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Modules.Common.Dtos.Requests.Book;
using Garuda.Modules.Common.Dtos.Responses;
using Garuda.Modules.Common.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Garuda.Modules.Common.Controllers
{
    [Produces("application/json")]
    [Route("api/books")]
    public class BookController : Controller
    {
        private readonly IBookService _iService;

        public BookController(IBookService iService)
        {
            _iService = iService;
        }

        /// <summary>
        /// Add Book Data.
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        [HttpPost]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(BookResponse))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST, Type = typeof(MessageDto))]
        public async Task<IActionResult> CreateData(BookCreateRequest model)
        {
            var (success, error) = await _iService.CreateData(model);
            if (error != null)
            {
                if (error.Status == Codes.NOT_FOUND)
                {
                    return NotFound(error);
                }
                else if (error.Status == Codes.BAD_REQUEST)
                {
                    return BadRequest(error);
                }
            }

            return Ok(success);
        }

        /// <summary>
        /// Get Book Data.
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        [HttpGet]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(BookResponse))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetData(Guid id)
        {
            var (success, error) = await _iService.GetDataById(id);
            if (error != null)
            {
                if (error.Status == Codes.NOT_FOUND)
                {
                    return NotFound(error);
                }
                else if (error.Status == Codes.BAD_REQUEST)
                {
                    return BadRequest(error);
                }
            }

            return Ok(success);
        }

        /// <summary>
        /// Get all Book Data.
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        [HttpGet("books")]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(List<BookResponse>))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST, Type = typeof(MessageDto))]
        public async Task<IActionResult> GetDatas()
        {
            var (success, error) = await _iService.GetAllData();
            if (error != null)
            {
                if (error.Status == Codes.NOT_FOUND)
                {
                    return NotFound(error);
                }
                else if (error.Status == Codes.BAD_REQUEST)
                {
                    return BadRequest(error);
                }
            }

            return Ok(success);
        }

        /// <summary>
        /// Update Book Data.
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        [HttpPut]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(BookResponse))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST, Type = typeof(MessageDto))]
        public async Task<IActionResult> UpdateData(BookUpdateRequest model)
        {
            var (success, error) = await _iService.UpdateData(model);
            if (error != null)
            {
                if (error.Status == Codes.NOT_FOUND)
                {
                    return NotFound(error);
                }
                else if (error.Status == Codes.BAD_REQUEST)
                {
                    return BadRequest(error);
                }
            }

            return Ok(success);
        }

        /// <summary>
        /// Delete Book Data by Id.
        /// </summary>
        /// <returns>A <see cref="BookResponse"/> representing the asynchronous operation.</returns>
        [HttpDelete]
        [ProducesResponseType(Codes.SUCCESS, Type = typeof(BookResponse))]
        [ProducesResponseType(Codes.NOT_FOUND, Type = typeof(MessageDto))]
        [ProducesResponseType(Codes.BAD_REQUEST, Type = typeof(MessageDto))]
        public async Task<IActionResult> DeleteDataById(Guid id)
        {
            var (success, error) = await _iService.DeleteDataById(id);
            if (error != null)
            {
                if (error.Status == Codes.NOT_FOUND)
                {
                    return NotFound(error);
                }
                else if (error.Status == Codes.BAD_REQUEST)
                {
                    return BadRequest(error);
                }
            }

            return Ok(success);
        }
    }
}
