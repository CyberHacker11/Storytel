using Storytel.SQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Storytel
{
    public partial class WindowCategories : Window
    {
        public WindowCategories()
        {
            InitializeComponent();
            
            var dtx = new DataClasses1DataContext();
            Bookss = (from b in dtx.Books select b).ToList();

            
            
            DataContext = this;

        }

        public List<Books> Bookss { get; set; }

        private void expSort_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
