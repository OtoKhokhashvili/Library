using Library.Models;
using System;
using System.Collections.Generic;

namespace Library.DataManagment
{
    public class BookManager
    {
        public List<Book> _bookList;

        private int _generatedID = 0;
        public BookManager()
        {
            _bookList = new List<Book>();
        }

        public int Add(Book book)
        {
            _generatedID++;
            book.Id = _generatedID;
            _bookList.Add(book);
            return book.Id;
        }

        public void Delete(int Id)
        {
            int index = GetIndexById(Id);
            if (index == -1)
            {
                throw new Exception("Book Id not found");
            }
            _bookList.RemoveAt(index);
        }

        public void Edit(Book book)
        {
            int index = GetIndexById(book.Id);
            if (index == -1)
            {
                throw new Exception("Book Id not found");
            }
            _bookList[index] = book;
        }       

        private int GetIndexById(int Id)
        {
            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Id == Id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
