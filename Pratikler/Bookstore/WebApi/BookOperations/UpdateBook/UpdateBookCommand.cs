using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DBOperations;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public UpdateBookModel Model { get; set; }
        public int BookId { get; set; }
        public UpdateBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handler()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
                throw new InvalidOperationException("Güncellenecek kitap bulunamamıştır");
            book.Title = Model.Title != default ? Model.Title : book.Title;
            book.GenreID = Model.GenreId != default ? Model.GenreId : book.GenreID;
            _dbContext.SaveChanges();
        }
    }
    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}