using BookManagementSystem.Models;
using System;

namespace BookManagementSystem.Views
{
    public interface IBookView
    {
        void Display(Book book, int daysRemaining, string colorCode);
    }
}