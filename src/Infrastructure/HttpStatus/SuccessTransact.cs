// <copyright file="SuccessTransact.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Infrastructure.Dtos;

namespace Garuda.Infrastructure.HttpStatus
{
    public class SuccessTransact
    {
        public SuccessTransact(int statusCode, string title, MessageLangDto messageValue, object objectValue)
        {
            Status = statusCode;
            Title = title;
            MessageIdn = messageValue.MessageIdn;
            MessageEng = messageValue.MessageEng;
            Data = objectValue;
        }

        /// <summary>
        /// Gets or sets for Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets for Status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets for MessageIdn
        /// </summary>
        public string MessageIdn { get; set; }

        /// <summary>
        /// Gets or sets for MessageEng
        /// </summary>
        public string MessageEng { get; set; }

        /// <summary>
        /// Gets or sets for Data
        /// </summary>
        public object Data { get; set; }
    }

}
