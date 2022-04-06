// <copyright file="MessageErrorDto.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

namespace Garuda.Infrastructure.Dtos
{
    public class MessageErrorDto
    {
        public MessageErrorDto(int errorCode, string title, string idn, string eng)
        {
            ErrorCode = errorCode;
            Title = title;
            MessageIdn = idn;
            MessageEng = eng;
        }

        public int ErrorCode { get; set; }

        public string Title { get; set; }

        public string MessageIdn { get; set; }

        public string MessageEng { get; set; }
    }
}
