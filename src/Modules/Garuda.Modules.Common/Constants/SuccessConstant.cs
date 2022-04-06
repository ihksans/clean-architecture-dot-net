// <copyright file="SuccessConstant.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.HttpStatus;

namespace Garuda.Modules.Common.Constants
{
    /// <summary>
    /// Success Constant
    /// Put every single message success in here.
    /// </summary>
    public class SuccessConstant
    {
        // Untuk menampilkan Source data
        public static readonly SuccessTransact FOUND_BOOKS = new SuccessTransact(Codes.SUCCESS, "Found", new MessageLangDto(null, "Book is Found"), null);
        public static readonly SuccessTransact BOOK_CREATED = new SuccessTransact(Codes.CREATED, "Created", new MessageLangDto(null, "Book has been creating"), null);
        public static readonly SuccessTransact BOOK_UPDATED = new SuccessTransact(Codes.SUCCESS, "Updated", new MessageLangDto(null, "Book has been updating"), null);
        public static readonly SuccessTransact BOOK_DELETED = new SuccessTransact(Codes.SUCCESS, "Deleted", new MessageLangDto(null, "Book has been deleting"), null);
    }
}
