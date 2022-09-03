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

        public AppManager()
        {
            LoadMenuItems();
        }

        public int MenuPosition
        {
            set { mMenuPosition = value; }
            get { return mMenuPosition; }
        }

        public int MenuLength
        {
            get { return mMenuItems.Count; }
        }

        private void LoadMenuItems()
        {
            string[] lines = File.ReadAllLines("MenuItems.txt");

            for (int i = 2; (i + 5) < lines.Length + 1; i = i + 5)
            {
                string title = lines[i + 1];
                string author = lines[i + 2];
                int rating = int.Parse(lines[i + 3]);
                string descrip = lines[i + 4];
                mMenuItems.Add(new MenuItem(title, author, rating, descrip));
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
