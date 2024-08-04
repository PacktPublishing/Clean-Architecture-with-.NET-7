﻿using AutoMapper;

namespace Application.Mapping
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Domain.Entities.OrderItem, Domain.Entities.ShoppingCartItem>();
            CreateMap<Domain.Entities.ShoppingCartItem, Domain.Entities.OrderItem>();
        }
    }
}
