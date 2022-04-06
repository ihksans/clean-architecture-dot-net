// <copyright file="BookSeeder.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;

namespace Garuda.Modules.Common.Models.Datas.Seed
{
    public class BookSeeder
    {
        public static Book[] Seed()
        {
            return new Book[]
            {
                new Book
                {
                    Id = new Guid("d45cb8d2-435e-4661-89d5-3daa96531712"), Name = "Larman", Price = "120000", CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000), CreatedBy = null, DeletedBy = null, UpdatedBy = null,
                },
            };
        }
    }
}
