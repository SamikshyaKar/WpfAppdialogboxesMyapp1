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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppdialogboxesMyapp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Name> names = new List<Name>();

        private ListWindow listdialg = null;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEnterName_Click(object sender, RoutedEventArgs e)
        {
            EnterWindow enterWindow_dlg = new EnterWindow();
            enterWindow_dlg.NameEntered += NewName;

            if(listdialg != null)
            {

                enterWindow_dlg.NameEntered += listdialg.newname;
                enterWindow_dlg.ShowDialog();

            }

        }

        public  void NewName(object sender, NameEventArgs e)
        {
            names.Add(e.Name);
        }

        private void btnShowList_Click(object sender, RoutedEventArgs e)
        {

            if(listdialg ==null)
            {
                listdialg = new ListWindow(names);
                listdialg.listcleared += listcleared;
                listdialg.listclosed += LISTCLOSED;
                listdialg.Show();
            }

        }

        public void LISTCLOSED(object sender, EventArgs e)
        {
            listdialg = null;
        }

        public void listcleared(object sender, EventArgs e)
        {
            names.Clear();
            listdialg.newname(this, null);

        }
    }
}
