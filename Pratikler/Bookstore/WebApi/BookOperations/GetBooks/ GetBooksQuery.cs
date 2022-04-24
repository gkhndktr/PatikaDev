using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
    private readonly BookStoreDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public List<BooksViewsModel> Handler()
    {
        var bookList = _dbContext.Books.OrderBy(x => x.Id).ToList<Book>();
        List<BooksViewsModel> vm = _mapper.Map<List<BooksViewsModel>>(bookList);
        
        return vm;
    }
    }

    public class BooksViewsModel
    {
    public string Title { get; set; }
    public int PageCount { get; set; }
    public string PublishDate { get; set; }
    public string Genre { get; set; }
    }
}