using BookManagementSystem.Models;
using BookManagementSystem.Views;
using BookManagementSystem.Utilities;
using System;

namespace BookManagementSystem.Presenters
{
    public class BookPresenter
    {
        private readonly IBookView view;

        public BookPresenter(IBookView view)
        {
            this.view = view;
        }

        public void DisplayBookInfo(Book book)
        {
            var daysRemaining = (book.DueDate - DateTime.Today).Days;
            var colorCode = ColorCodingUtility.GetColorCode(daysRemaining);
            view.Display(book, daysRemaining, colorCode);
        }
    }
}
