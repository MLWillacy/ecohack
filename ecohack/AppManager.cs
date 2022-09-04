using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                int rating = int.Parse(lines[2]);
                string descrip = lines[3];
                string tastes = lines[5];
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
    }
}
