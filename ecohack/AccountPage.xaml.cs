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

            Salty_Textbox.Text = mInstance.ThisUser.Salty.ToString().Remove(1, mInstance.ThisUser.Salty.ToString().Length -1);
            Sweet_Textbox.Text = mInstance.ThisUser.Sweet.ToString().Remove(1, mInstance.ThisUser.Sweet.ToString().Length -1); ;
            Sour_Textbox.Text = mInstance.ThisUser.Sour.ToString().Remove(1, mInstance.ThisUser.Sour.ToString().Length -1); ;
            Bitter_Textbox.Text = mInstance.ThisUser.Bitter.ToString().Remove(1, mInstance.ThisUser.Bitter.ToString().Length - 1);
            Spice_Textbox.Text = mInstance.ThisUser.Spice.ToString().Remove(1, mInstance.ThisUser.Spice.ToString().Length - 1);

        }

        private void Home_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new HomePage(mMain, mInstance);
        }

        private void User_Button_Clicked(object sender, RoutedEventArgs e)
        {
            mMain.Content = new AccountPage(mMain, mInstance);
        }

        private void Salty_Text_Changed(object sender, TextChangedEventArgs e)
        {
            try { mInstance.ThisUser.Salty = float.Parse(Salty_Textbox.Text); }
            catch { }
        }

        private void Sweet_Text_Changed(object sender, TextChangedEventArgs e)
        {
            try { mInstance.ThisUser.Sweet = float.Parse(Sweet_Textbox.Text); }
            catch { }
        }

        private void Sour_Text_Changed(object sender, TextChangedEventArgs e)
        {
            try { mInstance.ThisUser.Sour = float.Parse(Sour_Textbox.Text); }
            catch { }
        }

        private void Bitter_Text_Changed(object sender, TextChangedEventArgs e)
        {
            try { mInstance.ThisUser.Sour = float.Parse(Sour_Textbox.Text); }
            catch { }
        }

        private void Spice_Text_Changed(object sender, TextChangedEventArgs e)
        {
            try { mInstance.ThisUser.Spice = float.Parse(Spice_Textbox.Text); }
            catch { }
        }
    }
}
