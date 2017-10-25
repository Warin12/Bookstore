using Foundation;
using System;
using UIKit;
using System.Collections.Generic

namespace Bookstore
{
    public partial class bookstableviewcontroller : UITableViewController
    {
        //List<>

        public bookstableviewcontroller (IntPtr handle) : base (handle)
        {
        }
    }
    public class Book
    {
        public string name;
        public string Author;
        public string Editor;
        public int Year;
    
    
    }
}