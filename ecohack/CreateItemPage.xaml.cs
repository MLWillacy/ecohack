using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
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
    /// Interaction logic for CreateItemPage.xaml
    /// </summary>
    public partial class CreateItemPage : Page
    {
        Frame mMain;
        AppManager mInstance;

        string mTitle;
        string mDescription;

        public CreateItemPage(Frame pMain, AppManager pInstance)
        {
            InitializeComponent();
            mMain = pMain;
            mInstance = pInstance;
        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain,mInstance);
        }

        private void Back_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new MenuPage(mMain, mInstance);
        }

        private void title_text_changed(object sender, TextChangedEventArgs e)
        {
            mTitle = Title_text.Text;
        }

        private void description_text_changed(object sender, TextChangedEventArgs e)
        {
            mDescription = Title_text.Text;
        }

        private void Submit_Button_Clicked(object sender, RoutedEventArgs e)
        {
            string[] titleSplit = mTitle.Split(" ");
            string reformTitle = "";
            for (int i = 0; i < titleSplit.Length; i++)
            {
                reformTitle = reformTitle + titleSplit[i];
            }
            string fileName = mInstance.ThisUser.Name + "_" + reformTitle;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            FileStream fs = File.Create(fileName);
            fs.Close();


            StreamWriter sw = new StreamWriter(fileName);

            sw.WriteLine(mTitle);
            sw.WriteLine(mInstance.ThisUser.Name);
            sw.WriteLine("4");
            sw.WriteLine(mDescription);
            sw.Close();

            mInstance.ThisUser.Pence++;
            mInstance.ThisUser.Score++;

            mMain.Content = new HomePage(mMain, mInstance);

        }
    }
}
