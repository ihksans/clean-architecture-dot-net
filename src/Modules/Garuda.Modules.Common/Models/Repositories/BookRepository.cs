// <copyright file="BookRepository.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garuda.Database.Framework;
using Garuda.Modules.Common.Models.Contracts;
using Garuda.Modules.Common.Models.Datas;
using Microsoft.EntityFrameworkCore;

namespace Garuda.Modules.Common.Models.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public async Task<Book> AddData(Book model)
        {
            try
            {
                var result = await this.dbSet.AddAsync(model);

                return model;
            }
            catch (Exception ex)
            {
                var err = ex;
                throw;
            }
        }

        public async Task<Book> DeleteById(Guid id)
        {
            var data = await this.dbSet.FirstOrDefaultAsync(x => x.Id == id && x.DeletedDate == null);
            if (data != null)
            {
                this.dbSet.Remove(data);
            }

            return data;
        }

        public async Task<Book> GetById(Guid id)
        {
            var data = await this.dbSet.FirstOrDefaultAsync(x => x.Id == id);
            return data;
        }

        public async Task<List<Book>> GetList()
        {
            var data = await this.dbSet.Where(x => x.DeletedDate == null).ToListAsync();
            return data;
        }

        public async Task<Book> UpdateData(Book model)
        {
            var data = await this.dbSet.FirstOrDefaultAsync(x => x.Id == model.Id && x.DeletedDate == null);
            if (data != null)
            {
                data.Name = model.Name;
                data.Price = model.Price;
                this.dbSet.Update(data);
            }

            return data;
        }
    }
}
