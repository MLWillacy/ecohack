using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Formats.Asn1.AsnWriter;

namespace ecohack
{
    public class AppManager
    {
        List<MenuItem> mMenuItems = new List<MenuItem>();
        int mMenuPosition = 0;
        User mUser;

        public AppManager(User pUser)
        {
            LoadMenuItems();
            mUser = pUser;
        }

        public int MenuPosition
        {
            set { mMenuPosition = value; }
            get { return mMenuPosition; }
        }

        public User ThisUser
        {
            get { return mUser; }
        }
        

        public int MenuLength
        {
            get { return mMenuItems.Count; }
        }

        private void LoadMenuItems()
        {
            foreach (string file in Directory.EnumerateFiles("MenuItems", "*.txt"))
            {
                string contents = File.ReadAllText(file);
                string[] lines = contents.Split('\n');

                string title = lines[0];
                string author = lines[1];
                float rating = float.Parse(lines[2]);
                string descrip = lines[3];
                string tastes = lines[4];
                mMenuItems.Add(new MenuItem(title, author, rating, descrip, tastes, file));
            }
        }

        public List<MenuItem> getMenuItems()
        {
            List<MenuItem> itemsToDisplay = new List<MenuItem>();

            for (int i = 0; i < 3; i++)
            {
                try
                { itemsToDisplay.Add(mMenuItems[i + mMenuPosition]); }
                catch
                {
                    if (i == 0)
                    { return null; }
                }
            }

            return itemsToDisplay;
        }

        public void replaceMenuItem(MenuItem pItem)
        {
            for (int i = 0; i < mMenuItems.Count; i++ )
            {

                if (mMenuItems[i].Title == pItem.Title)
                {
                    mMenuItems[i] = pItem;
                }
            }

            StreamWriter sw = new StreamWriter(pItem.Path);

            sw.WriteLine(pItem.Title);
            sw.WriteLine(pItem.Author);
            sw.WriteLine(pItem.Rating);
            sw.WriteLine(pItem.Description);
            sw.WriteLine(pItem.Salty + "," + pItem.Sweet + "," + pItem.Sour + "," + pItem.Bitter + "," + pItem.Spice);

            sw.Close();
        }
    }
}
