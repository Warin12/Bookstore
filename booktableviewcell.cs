using Foundation;
using System;
using UIKit;

namespace Bookstore
{
    public partial class booktableviewcell : UITableViewCell
    {
        
        private Book bookData;

        public Book BookData
        {
            get { return bookData; }
            set {
                bookData = value;

                labelname.Text = bookData.Name;
                labelyear.Text = bookData.Year.ToString();
                labelauthor.Text = bookData.Author;
                labeleditor.Text = bookData.Publisher;
            }
        }

       


        public booktableviewcell (IntPtr handle) : base(handle)
        {

        }
    }
}
