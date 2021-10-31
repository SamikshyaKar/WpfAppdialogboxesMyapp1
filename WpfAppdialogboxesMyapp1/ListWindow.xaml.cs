using System;
using System.Collections.Generic;
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

namespace WpfAppdialogboxesMyapp1
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    /// 

    public delegate void clearlistener(object sender, EventArgs e);

    public delegate void closelistener(object sender, EventArgs e);

    public partial class ListWindow : Window
    {

        public event clearlistener listcleared;

        public event closelistener listclosed;

        private List<Name> names;

        public ListWindow(List<Name> names)
        {
            InitializeComponent();

            this.names = names;
            lstshow.ItemsSource = names;
        }

        private void Btnclear_Click(object sender, RoutedEventArgs e)
        {

            if(listcleared !=null)
            {
                listcleared(this, new EventArgs());
            }

        }

        private void Btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_closed(object sender, EventArgs e)
        {
            if( listclosed !=null)
            {
                listclosed(this, new EventArgs());

            }
        }

        private void lstshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        public void newname (object sender, NameEventArgs e)
        {
            lstshow.ItemsSource = null;
            lstshow.ItemsSource = names;

        }
    }
}
