// <copyright file="BookCreateRequest.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

namespace Garuda.Modules.Common.Dtos.Requests.Book
{
    public class BookCreateRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or Sets for Price.
        /// </summary>
        public string Price { get; set; }
    }
}
