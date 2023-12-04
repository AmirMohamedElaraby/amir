using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        Assessment1Entities db = new Assessment1Entities();
        public SignUp()
        {
            InitializeComponent();
        }

        private bool isvalid(string password)
        {
            bool lower, digit, special;
            lower = digit = special = false;
            string set = "!@#$%^&*()_";
            foreach (char s in password)
            {

                if (s >= 'a' && s <= 'b')
                { lower = true; }
                else if (s >= '0' && s <= '9')
                { digit = true; }
                else if (set.Contains(s))
                {
                    special = true;
                }

            }
            return lower && digit && special;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Userr tab = new Userr();
                tab.Username = username.Text;
                if (isvalid(password.Text))
                {
                    tab.Passwordd = password.Text;
                }
                else { MessageBox.Show("password must contain digit nums chars"); }
                if (Amir3.Text.Length == 11)
                {
                    tab.Phone_number = Amir3.Text;
                }
                else { MessageBox.Show("number must be 11  digit length "); }

                int age = int.Parse(Agetxt.Text);
                if (age >= 18 && age <= 60)
                {
                    tab.Age = int.Parse(Agetxt.Text);
                }
                else { MessageBox.Show("age must be between 18 and 60 "); }
                if (Male.IsEnabled)
                {
                    tab.Gender = "male";
                }
                else if (Female.IsEnabled)
                {
                    tab.Gender = "female";

                }
                else { MessageBox.Show("choose only 1 gender"); }
                tab.City = combo.Text;
                db.Userrs.Add(tab);
                db.SaveChanges();
                MessageBox.Show("a new user has been added go sign in");
            }
            catch { MessageBox.Show("wrong input unable to add user"); }

        }
    
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sign_in sign_In = new Sign_in();
            this.NavigationService.Navigate(sign_In);
        }
    }
}
    

