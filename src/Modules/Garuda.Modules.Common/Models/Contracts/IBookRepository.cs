// <copyright file="IBookRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garuda.Abstract.Contracts;
using Garuda.Modules.Common.Models.Datas;

namespace Garuda.Modules.Common.Models.Contracts
{
    /// <summary>
    /// Entity Group Contract IBookRepository
    /// </summary>
    public interface IBookRepository : IRepository
    {
        /// <summary>
        /// Add data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task<Book> AddData(Book model);

        /// <summary>
        /// Delete data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task<Book> DeleteById(Guid id);

        /// <summary>
        /// Get 1 Data By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task<Book> GetById(Guid id);

        /// <summary>
        /// Get List Data without Filter
        /// </summary>
        /// <returns>A <see cref="List{Book}"/> representing the asynchronous operation.</returns>
        Task<List<Book>> GetList();

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>A <see cref="Book"/> representing the asynchronous operation.</returns>
        Task<Book> UpdateData(Book model);
    }
}
