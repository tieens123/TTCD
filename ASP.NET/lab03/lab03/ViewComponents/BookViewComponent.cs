using Microsoft.AspNetCore.Mvc;
using lab03.Models;




namespace lab03.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        
            protected Book book = new Book();
            public IViewComponentResult Invoke()
            {
                var books = book.GetBookList();
                return View(books);
            }
        
    }
}
