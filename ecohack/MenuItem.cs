using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecohack
{
    public class MenuItem
    {
        string mTitle;
        string mAuthor;
        int mRating;
        string mDescription;

        public MenuItem(string pTitle, string pAuthor, int pRating, string pDescription)
        {
            mTitle = pTitle;
            mAuthor = pAuthor;
            mRating = pRating;
            mDescription = pDescription;
        }

        public string Title
        { get { return mTitle; } }

        public string Author
        { get { return mAuthor; } }

        public int Rating
        { get { return mRating; } }

        public string Description
        { get { return mDescription; } }

    }
}
