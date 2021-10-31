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
    /// Interaction logic for EnterWindow.xaml
    /// </summary>
    /// 
     public class NameEventArgs:EventArgs
    {

        //private Name fname;

        //private Name lname;

        //public NameEventArgs(Name fname,Name lname)
        //{
        //    this.fname = fname;
        //    this.lname = lname;
        //}

        //public Name FName
        //{
        //    get { return fname; }

        //}


        //public Name LName
        //{
        //    get { return lname; }

        //}
        //public Name names { get; set; }

        //public Name firstname { get; set; }

        //public Name lastname { get; set; }


        private Name name;

        public NameEventArgs(Name name)
        {
            this.name = name;
        }

        public Name Name
        {

            get { return name; }
        }



    }

    public delegate void NameListener(object sender, NameEventArgs e);

         


    public partial class EnterWindow : Window
    {

        public event NameListener NameEntered;
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();

            if(firstname.Length > 0 && lastname.Length > 0)
            {
                if(NameEntered !=null)
                {
                    NameEntered(this, new NameEventArgs(new Name(firstname, lastname)));

                    //NameEntered(this, new NameEventArgs (Name)(firstname, lastname));

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtFirstName.Focus();

                }
                else
                {

                    MessageBox.Show("You must enter firstname and lastname","Warning");
                }

            }

            
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
