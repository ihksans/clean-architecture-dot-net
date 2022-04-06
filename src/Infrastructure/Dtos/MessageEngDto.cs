// <copyright file="MessageEngDto.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

namespace Garuda.Infrastructure.Dtos
{
    public class MessageEngDto
    {
        public MessageEngDto(string title, string eng)
        {
            Title = title;
            MessageEng = eng;
        }

        public string Title { get; set; }

        public string MessageEng { get; set; }
    }
}
