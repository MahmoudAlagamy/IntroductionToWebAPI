using IntroductionToWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroductionToWebAPI.Controllers
{
    public class BooksController : ApiController
    {

        //// Get primitive parameters (int, string, ... etc)
        ////  API => https://localhost:44356/api/books/GetBook?title=Java&numberOfPages=50
        //public string GetBook(string title, int numberOfPages)
        //{
        //    return string.Format("Title = {0}, Number Of Pages = {1}", title,numberOfPages);
        //}

        // Get primitive parameters (int, string, ... etc)
        //  API => https://localhost:44356/api/books/GetBook?title=Java&numberOfPages=50
        public string GetBook([FromBody] string title, int numberOfPages)
        {
            return string.Format("Title = {0}, Number Of Pages = {1}", title, numberOfPages);
        }

        // Post primitive parameters (int, string, ... etc)
        //  API => https://localhost:44356/api/books/PostBook?title=Java&numberOfPages=50
        [HttpPost]
        public string PostBook(string title, int numberOfPages)
        {
            return string.Format("Title = {0}, Number Of Pages = {1}", title, numberOfPages);
        }

        // Get complix parameters
        //  API => https://localhost:44356/api/books
        public HttpResponseMessage GetBook(Book book)
        {
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
                //return string.Format("Title = {0}, Number Of Pages = {1}", book.Title, book.NumberOfPages);

            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // Post complix parameters
        // API => https://localhost:44356/api/books
        public string PostBook(Book book)
        {
            return string.Format("Title = {0}, Number Of Pages = {1}", book.Title, book.NumberOfPages);
        }

        // Get complix and primitive parameters
        //  API => https://localhost:44356/api/books?author=AGAMY
        public string GetBook(Book book, string author)
        {
            return string.Format("Title = {0}, Number Of Pages = {1}, Author = {2}", book.Title, book.NumberOfPages, author);
        }

        // Post complix and primitive parameters
        //  API => https://localhost:44356/api/books?author=AGAMY
        public string PostBook(Book book, string author)
        {
            return string.Format("Title = {0}, Number Of Pages = {1}, Author = {2}", book.Title, book.NumberOfPages, author);
        }

        // [FromBody] [FromUri]



    }
}