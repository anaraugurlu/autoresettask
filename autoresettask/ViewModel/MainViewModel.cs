using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoresettask.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //public RelayCommand SelectBookCommand { get; set; }
        //public RelayCommand AddCommand { get; set; }
      
        public MainViewModel(MainWindow mainWindow)
        {
            //SelectedBook = new Book();
            //AllBooks = App.DB.BookRepository.GetAllData();
            //DeleteBookCommand = new RelayCommand((sender) =>
            //{
            //    App.DB.BookRepository.DeleteData(SelectedBook.Id);
            //    AllBooks = App.DB.BookRepository.GetAllData();
            //    MessageBox.Show("Delete Book Succesfully");

            //}, (pred) =>
            //{
            //    if (SelectedBook != null && SelectedBook.Id != 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //});
            //ResetCommand = new RelayCommand((sender) =>
            //{
            //    SelectedBook = new Book();
            //});
            //SelectBookCommand = new RelayCommand((sender) =>
            //{
            //    if (SelectedBook != null)
            //    {
            //        var book = App.DB.BookRepository.GetData(SelectedBook.Id);
            //        SelectedBook = book;
            //    }
            //});
            //AddCommand = new RelayCommand((sender) =>
            //{

            //    var item = App.DB.BookRepository.GetData(SelectedBook.Id);

            //    if (item.Id == 0)
            //    {

            //        App.DB.BookRepository.AddData(SelectedBook);
            //        AllBooks = App.DB.BookRepository.GetAllData();
            //            MessageBox.Show("Add Successfully");
            //        }
            //        else
            //        {
            //            MessageBox.Show("This customer is already exists");
            //        }
            //        SelectedBook = new Book();
            //    });
            //    UpdateCommand = new RelayCommand((sender) =>
            //    {
            //        App.DB.BookRepository.UpdateData(SelectedBook);
            //        MessageBox.Show("Update Successfully");
            //        SelectedBook = new Book();
            //    });
            //}
            //private List<Book> allBooks;
            //public List<Book> AllBooks
            //{
            //    get { return allBooks; }
            //    set { allBooks = value; OnPropertyChanged(); }
            //}
            //private Book selectedBook;
            //public Book SelectedBook
            //{
            //    get { return selectedBook; }
            //    set { selectedBook = value; OnPropertyChanged(); }
            //}
        }
    }
}

