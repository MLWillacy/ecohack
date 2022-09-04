using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    /// Interaction logic for ReviewPage.xaml
    /// </summary>
    public partial class ReviewPage : Page
    {
        Frame mMain;
        AppManager mInstance;
        MenuItem mThisItem;
        public ReviewPage(Frame pMain, AppManager pInstance, MenuItem pThisItem)
        {
            InitializeComponent();
            mMain = pMain;
            mInstance = pInstance;
            mThisItem = pThisItem;
            LoadPage();
        }

        private void LoadPage()
        {
            Title_text.Content = mThisItem.Title;
            Descrip_text.Content = mThisItem.Description;
        }
        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain, mInstance);
        }

        private void Back_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new MenuPage(mMain, mInstance);
        }

        private void Submit_Button_Clicked(object sender, RoutedEventArgs e)
        {
            Review_Button.Visibility = Visibility.Visible;
        }

        private void star1_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 1)/2;
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void star2_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 2) / 2;
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void star4_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 4) / 2;
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void star5_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 5) / 2;
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void star3_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 3) / 2;
            mMain.Content = new HomePage(mMain, mInstance);
        }
    }
}
