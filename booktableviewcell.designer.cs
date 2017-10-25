// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bookstore
{
    [Register ("booktableviewcell")]
    partial class booktableviewcell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelauthor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labeleditor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelyear { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelauthor != null) {
                labelauthor.Dispose ();
                labelauthor = null;
            }

            if (labeleditor != null) {
                labeleditor.Dispose ();
                labeleditor = null;
            }

            if (labelname != null) {
                labelname.Dispose ();
                labelname = null;
            }

            if (labelyear != null) {
                labelyear.Dispose ();
                labelyear = null;
            }
        }
    }
}