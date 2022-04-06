// <copyright file="UserSeeder.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>
using System;

namespace Garuda.Modules.Common.Models.Datas.Seeder
{
    public class UserSeeder
    {
        public static User[] Seed()
        {
            return new User[]
            {
                    new User
                    {
                        Id = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        Email = "system@system.co",
                        IsActive = true,
                        Username = "systemadmin",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000),
                        Fullname = "System",
                    },
                    new User
                    {
                        Id = Guid.Parse("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                        Email = "systemreserve@system.co",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000),
                        IsActive = true,
                        Username = "systemadminreserve",
                        Fullname = "System Admin Reserve",
                    },
                    new User
                    {
                        Id = Guid.Parse("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                        Email = "rezacodym@gmail.com",
                        IsActive = true,
                        Username = "reza_reza",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000),
                        Fullname = "Reza Muharam",
                    },
                    new User
                    {
                        Id = Guid.Parse("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                        Email = "atthoriqgf@gmail.com",
                        IsActive = true,
                        Username = "atthoriq_atthoriq",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000),
                        Fullname = "Atthoriq",
                    },
                    new User
                    {
                        Id = Guid.Parse("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                        Email = "dermawanto_d@banpuindo.co.id",
                        IsActive = true,
                        Username = "dermawanto_d",
                        CreatedBy = Guid.Parse("81314787-537b-474f-999a-9152c9703bbb"),
                        CreatedDate = new DateTime(2022, 04, 11, 00, 00, 00, 000),
                        Fullname = "Dermawanto",
                    },
            };
        }
    }
}
