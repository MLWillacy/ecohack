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
        float mRating;
        string mDescription;
        float mSalty;
        float mSweet;
        float mSour;
        float mBitter;
        float mSpice;
        string mPath;

        public MenuItem(string pTitle, string pAuthor, float pRating, string pDescription, string pTastes, string pPath)
        {
            mTitle = pTitle;
            mAuthor = pAuthor;
            mRating = pRating;
            mDescription = pDescription;
            string[] tastesSplit = pTastes.Split(',');
            mSalty = float.Parse(tastesSplit[0]);
            mSweet = float.Parse(tastesSplit[1]);
            mSour = float.Parse(tastesSplit[2]);
            mBitter = float.Parse(tastesSplit[3]);
            mSpice = float.Parse(tastesSplit[4]);
            mPath = pPath;
        }

        public string Title
        { get { return mTitle; } }

        public string Author
        { get { return mAuthor; } }

        public float Rating
        {
            get { return mRating; }
            set 
            { 
                if (value > 5)
                { value = 5; }
                mRating = value; 
            }
        }



        public string Description
        { get { return mDescription; } }

    }
}
