using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Bookstore
{
    public partial class bookstableviewcontroller : UITableViewController
    {

        List<Book> booklist;

        public bookstableviewcontroller (IntPtr handle) : base (handle)
        {
            booklist = new List<Book>();
        
            booklist.Add(new Book() {
                Author = "J.K. Rowling", 
                Name = "Harry Potter and the Sorcerer's Stone",
                Publisher = "Bloomsbury",
                Year = 1997, 
           ImagePath = "Images/images.jpg"
            });
			
            booklist.Add(new Book()
			{
				Author = "J.K. Rowling",
                Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998
			});
			
            booklist.Add(new Book()
			{
				Author = "J.K. Rowling",
                Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999
			});
       
       }
       

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return booklist.Count;
        }
    
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as booktableviewcell;

            var data = booklist[indexPath.Row];

            cell.BookData = data;

            return cell;
        }
    } 
    public class Book

    {
        public string Name;
        public string Author;
        public string Publisher;
        public int Year;
        public string ImagePath;
    
    }
}