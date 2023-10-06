﻿namespace Application.Features.Brands.Commands.Create
{
    public class CreatedBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}