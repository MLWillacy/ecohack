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

namespace ecohack
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        Frame mMain;
        AppManager mInstance;
        public HomePage(Frame pMain, AppManager pInstance)
        {
            InitializeComponent();
            mMain = pMain;
            mInstance = pInstance;
            setHomeBackground();
        }

        private void setHomeBackground()
        {
            int score = mInstance.ThisUser.Score;
            if (score > 20)
            {
                Background_Image.Source = new BitmapImage(new Uri(@"/Images/HomeBackground5.png", UriKind.Relative));
            }
            else if (score > 10)
            {
                Background_Image.Source = new BitmapImage(new Uri(@"/Images/HomeBackground4.png", UriKind.Relative));
            }
            else if (score > 5)
            {
                Background_Image.Source = new BitmapImage(new Uri(@"/Images/HomeBackground3.png", UriKind.Relative));
            }
            else if (score > 0)
            {
                Background_Image.Source = new BitmapImage(new Uri(@"/Images/HomeBackground2.png", UriKind.Relative));
            }
            else
            {
                Background_Image.Source = new BitmapImage(new Uri(@"/Images/HomeBackground1.png", UriKind.Relative));
            }
        }
        private void Plate_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new MenuPage(mMain,mInstance);
        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain,mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain,mInstance);
        }
    }
}
