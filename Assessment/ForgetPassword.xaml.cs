using Assessment;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Assessment
{
    /// <summary>
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Page
    {
        Assessment1Entities db = new Assessment1Entities();

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userr d = new Userr();
            if (Combo.Text == "a")
            {
                d = db.Userrs.FirstOrDefault(x => x.Phone_number == Phonenumber.Text );
                if (d != null)
                {
                    d.Phone_number = Phonenumber.Text;
                    db.Userrs.AddOrUpdate(d);
                    db.SaveChanges();
                    MessageBox.Show("update");
                }
                else
                {
                    MessageBox.Show("FAIL");
                }


            }
            else
            {
                MessageBox.Show("select admin only");
            }
        }
    }
}

