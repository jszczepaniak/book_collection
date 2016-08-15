using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_collection
{
    public partial class main : Form
    {
        List<book> books;
        List<author> authors;
        public main()
        {
            InitializeComponent();
            authors.Add(new author("Nazwisko"));

        }
    }
}
