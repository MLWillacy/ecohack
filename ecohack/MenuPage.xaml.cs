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
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Frame mMain;
        AppManager mInstance;
        public MenuPage(Frame pMain, AppManager pInstance)
        {
            InitializeComponent();
            mMain = pMain;
            mInstance = pInstance;
            loadMenuItems();
        }

        private void loadMenuItems()
        {
            List<MenuItem> itemsToDisplay = mInstance.getMenuItems();
            if (itemsToDisplay == null)
            {
                return;
            }
        
            MenuItem1_Button.Visibility = Visibility.Visible;
            MenuItem1_Button.Visibility = Visibility.Visible;
            MenuItem1_Button.Visibility = Visibility.Visible;

            try
            {
                MenuItem1_Title.Content = itemsToDisplay[0].Title;
                MenuItem1_Author.Content = "Author: " + itemsToDisplay[0].Author;

                MenuItem1Star1_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem1Star2_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem1Star3_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem1Star4_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem1Star5_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                if (itemsToDisplay[0].Rating < 5)
                {
                    MenuItem1Star5_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[0].Rating < 4)
                {
                    MenuItem1Star4_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[0].Rating < 3)
                {
                    MenuItem1Star3_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[0].Rating < 2)
                {
                    MenuItem1Star2_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[0].Rating < 1)
                {
                    MenuItem1Star1_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
            }
            catch
            { MenuItem1_Button.Visibility = Visibility.Hidden; }
            try
            {
                MenuItem2_Title.Content = itemsToDisplay[1].Title;
                MenuItem2_Author.Content = "Author: " + itemsToDisplay[1].Author;

                MenuItem2Star1_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem2Star2_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem2Star3_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem2Star4_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem2Star5_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                if (itemsToDisplay[1].Rating < 5)
                {
                    MenuItem2Star5_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[1].Rating < 4)
                {
                    MenuItem2Star4_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[1].Rating < 3)
                {
                    MenuItem2Star3_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[1].Rating < 2)
                {
                    MenuItem2Star2_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[1].Rating < 1)
                {
                    MenuItem2Star1_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
            }
            catch
            { MenuItem2_Button.Visibility = Visibility.Hidden; }
            try
            {
                MenuItem3_Title.Content = itemsToDisplay[2].Title;
                MenuItem3_Author.Content = "Author: " + itemsToDisplay[2].Author;

                MenuItem3Star1_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem3Star2_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem3Star3_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem3Star4_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                MenuItem3Star5_Image.Source = new BitmapImage(new Uri(@"/Images/FullStar.png", UriKind.Relative));
                if (itemsToDisplay[2].Rating < 5)
                {
                    MenuItem3Star5_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[2].Rating < 4)
                {
                    MenuItem3Star4_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[2].Rating < 3)
                {
                    MenuItem3Star3_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[2].Rating < 2)
                {
                    MenuItem3Star2_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
                if (itemsToDisplay[2].Rating < 1)
                {
                    MenuItem3Star1_Image.Source = new BitmapImage(new Uri(@"/Images/EmptyStar.png", UriKind.Relative));
                }
            }
            catch
            { MenuItem3_Button.Visibility = Visibility.Hidden; }


        }

        private void Add_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new CreateItemPage(mMain,mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain,mInstance);
        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void Up_Button_Clicked(object sender, RoutedEventArgs e)
        {
            int newPos = mInstance.MenuPosition - 3;
            if (!(newPos < 0 ))
            { mInstance.MenuPosition = newPos; }
            loadMenuItems();
        }

        private void Down_Button_Clicked(object sender, RoutedEventArgs e)
        {
            int newPos = mInstance.MenuPosition + 3;
            if ((newPos < mInstance.MenuLength))
            { mInstance.MenuPosition = newPos; }
            loadMenuItems();
        }

        private void MenuItem1_Button_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem2_Button_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem3_Button_Clicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
