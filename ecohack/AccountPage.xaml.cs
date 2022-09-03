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
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Page
    {
        Frame mMain;
        AppManager mInstance;
        public AccountPage(Frame pMain, AppManager pInstance)
        {
            InitializeComponent();
            mMain = pMain;
            mInstance = pInstance;
            LoadPage();
        }

        private void LoadPage()
        {
            UserName_Text.Text = mInstance.ThisUser.Name;
            if (mInstance.ThisUser.Pence < 10)
            { Balance_Text.Text = "£" + mInstance.ThisUser.Pound + ".0" + mInstance.ThisUser.Pence; }
            else { Balance_Text.Text = "£" + mInstance.ThisUser.Pound + "." + mInstance.ThisUser.Pence; }
        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain, mInstance);
        }
    }
}
