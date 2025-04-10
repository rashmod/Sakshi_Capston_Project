﻿using AutoMapper;
using LibraryManagement.Api.DTO;
using LibraryManagement.Domain.Models;


namespace LibraryManagement.Api.Mapper
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserRegisterRequestDto, ApplicationUser>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()))
            .ForMember(dest => dest.NormalizedUserName, opt => opt.MapFrom(src => src.Email.ToUpper()));

            CreateMap<LoanRequestDto, Loan>();
            CreateMap<PaymentRequestDto, Payment>();
            CreateMap<AuthorRequestDto, Author>();
            CreateMap<BookRequestDto, Book>();

        }


    }
}
