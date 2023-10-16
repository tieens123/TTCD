using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenerId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sách các cuốn sách 
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() { 
                    Id = 1,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenerId = 1,
                    Image = "/images/products/anh1.jpg",
                    Price = 10000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 1,
                    Title = "thị nở",
                    AuthorId = 1,
                    GenerId = 1,
                    Image = "/images/products/anh2.jpg",
                    Price = 10000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 1,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenerId = 1,
                    Image = "/images/products/anh3.jpg",
                    Price = 10000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 1,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenerId = 1,
                    Image = "/images/products/anh2.jpg",
                    Price = 10000,
                    Sumary = "",
                    TotalPage = 250
                },


            };
            return books;
        }

        //chi tiết một cuốn sách theo id 
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //selectListItem Authors 
        public List<SelectListItem> Authors { get;  } = new List<SelectListItem>
        {
            new SelectListItem {Value= "1", Text= "Nam Cao"},
            new SelectListItem {Value= "2", Text= "Ngô Tất Tố"},
            new SelectListItem {Value= "3", Text= "Adam"},
            new SelectListItem {Value= "4", Text= "Thiền sư"}
        };

        //selectListItem genres
        public List<SelectListItem> Genrer { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value= "1", Text="Truyện tranh"},
            new SelectListItem { Value= "2", Text="Văn học đương đại "},
            new SelectListItem { Value= "3", Text="Phật học phổ thông"},
            new SelectListItem { Value= "4", Text="truyện cười"}

        };
    }
}
