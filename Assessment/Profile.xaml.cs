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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();

            //this.label.Content = passtxt + "'s ";
            //this.nametxt.Content = s.username;
            //this.passtxt.Content = "*********";
            //this.citytxt.Content = s.city;
            //this.phonetxt.Content = s.phone;
            //this.agetxt.Content = s.age;
            //this.gendertxt.Content = s.gender;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sign_in sign_In = new Sign_in();
            this.NavigationService.Navigate(sign_In);
        }
    }
}
