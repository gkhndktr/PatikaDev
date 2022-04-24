using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;

namespace WebApi.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookDetailViewModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreID).ToString()));
            CreateMap<Book, BooksViewsModel>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreID).ToString()));
        }
    }
}