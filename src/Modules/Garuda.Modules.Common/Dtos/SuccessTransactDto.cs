// <copyright file="SuccessTransactDto.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using Garuda.Infrastructure.HttpStatus;

namespace Garuda.Modules.Common.Dtos
{
    public class SuccessTransactDto
    {
        public SuccessTransactDto(SuccessTransact status, object data)
        {
            Status = status.Status;
            Title = status.Title;
            MessageIdn = status.MessageIdn;
            MessageEng = status.MessageEng;
            Data = data;
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
