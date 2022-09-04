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

        private void updateTaste()
        {
            if (mThisItem.Salty > mInstance.ThisUser.Salty)
            {
                mThisItem.Salty = mThisItem.Salty - 0.1;
                mInstance.ThisUser.Salty = mThisItem.Salty + 0.1;
            }
            else if (mThisItem.Salty < mInstance.ThisUser.Salty)
            {
                mThisItem.Salty = mThisItem.Salty + 0.1;
                mInstance.ThisUser.Salty = mThisItem.Salty - 0.1;
            }

            if (mThisItem.Sweet > mInstance.ThisUser.Sweet)
            {
                mThisItem.Sweet = mThisItem.Sweet - 0.1;
                mInstance.ThisUser.Sweet = mThisItem.Sweet + 0.1;
            }
            else if (mThisItem.Sweet < mInstance.ThisUser.Sweet)
            {
                mThisItem.Sweet = mThisItem.Sweet + 0.1;
                mInstance.ThisUser.Sweet = mThisItem.Sweet - 0.1;
            }

            if (mThisItem.Sour > mInstance.ThisUser.Sour)
            {
                mThisItem.Sour = mThisItem.Sour - 0.1;
                mInstance.ThisUser.Sour = mThisItem.Sour + 0.1;
            }
            else if (mThisItem.Sour < mInstance.ThisUser.Sour)
            {
                mThisItem.Sour = mThisItem.Sour + 0.1;
                mInstance.ThisUser.Sour = mThisItem.Sour - 0.1;
            }

            if (mThisItem.Bitter > mInstance.ThisUser.Bitter)
            {
                mThisItem.Bitter = mThisItem.Bitter - 0.1;
                mInstance.ThisUser.Bitter = mThisItem.Bitter + 0.1;
            }
            else if (mThisItem.Bitter < mInstance.ThisUser.Bitter)
            {
                mThisItem.Bitter = mThisItem.Bitter + 0.1;
                mInstance.ThisUser.Bitter = mThisItem.Bitter - 0.1;
            }

            if (mThisItem.Spice > mInstance.ThisUser.Spice)
            {
                mThisItem.Spice = mThisItem.Spice - 0.1;
                mInstance.ThisUser.Spice = mThisItem.Spice + 0.1;
            }
            else if (mThisItem.Spice < mInstance.ThisUser.Spice)
            {
                mThisItem.Spice = mThisItem.Spice + 0.1;
                mInstance.ThisUser.Spice = mThisItem.Spice - 0.1;
            }

            mInstance.replaceMenuItem(mThisItem);
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
            updateTaste();
        }

        private void star5_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 5) / 2;
            mMain.Content = new HomePage(mMain, mInstance);
            updateTaste();
        }

        private void star3_button_clicked(object sender, RoutedEventArgs e)
        {
            mThisItem.Rating = (mThisItem.Rating + 3) / 2;
            updateTaste();
            mMain.Content = new HomePage(mMain, mInstance);
        }
    }
}
