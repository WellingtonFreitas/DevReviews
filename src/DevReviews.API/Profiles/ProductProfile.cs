﻿using AutoMapper;
using DevReviews.API.Entities;
using DevReviews.API.Models;

namespace DevReviews.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductReview, ProductReviewsModel>();
            CreateMap<ProductReview, ProductReviewDetailsViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, ProductDetailsViewModel>();
        }
    }
}
