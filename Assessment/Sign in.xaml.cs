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

namespace Assessment
{

    /// <summary>
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Page
    {
           Assessment1Entities db = new Assessment1Entities();
        public Sign_in()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userr user = new Userr();
            try
            {

                Userr h = db.Userrs.FirstOrDefault(x => x.Username == user1.Text && x.Passwordd == password1.Text);
          
                if (db != null)
                {
                    string Passwordd = password1.Text;
                    MessageBox.Show("right information");
                    Profile aa = new Profile();
                    this.NavigationService.Navigate(aa);

                }
                else
                {
                    MessageBox.Show("check the password and username again");
                }
            }
            catch 
            {
                MessageBox.Show("wrong input");
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.NavigationService.Navigate(signUp);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            this.NavigationService.Navigate(forgetPassword);
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
