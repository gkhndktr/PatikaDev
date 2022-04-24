using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper )
        {
        _dbContext = dbContext;
        _mapper = mapper;
        }
        public BookDetailViewModel Handler()
        {
        var book = _dbContext.Books.Where(x => x.Id == BookId).SingleOrDefault();
        if (book is null)
        {
            throw new InvalidOperationException("Kitap Bulunamamıştır!");
        }
        BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book);
        return vm;
        }
    }
    public class BookDetailViewModel
    {
    public string Title { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }
    public string PublishDate { get; set; }
    }
}