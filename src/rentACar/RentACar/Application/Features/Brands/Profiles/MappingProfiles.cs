﻿using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
            
            CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();
            CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
            
            CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();

            CreateMap<Brand,UpdatedBrandResponse>().ReverseMap();
            CreateMap<Brand,UpdateBrandCommand>().ReverseMap();
        }
    }
}