using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ecohack
{
    public class MenuItem
    {
        string mTitle;
        string mAuthor;
        double mRating;
        string mDescription;
        double mSalty;
        double mSweet;
        double mSour;
        double mBitter;
        double mSpice;
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

        public void updateItem()
        {

        }

        public string Title
        { get { return mTitle; } }

        public string Author
        { get { return mAuthor; } }

        public double Rating
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

        public string Path
        { get { return mPath; } }
        public double Salty
        {
            get { return mSalty; }
            set 
            {
                if (value > 10)
                { value = 10; }
                else if (value < 0)
                { value = 0; }
                mSalty = value; 
                updateItem();
            }

        }

        public double Sweet
        {
            get { return mSweet; }
            set 
            {
                mSweet = value;
                updateItem();
            }
        }

        public double Sour
        {
            get { return mSour; }
            set 
            { 
                mSour = value;
                updateItem();
            }
        }
        public double Bitter
        {
            get { return mBitter; }
            set 
            {
                if (value > 10)
                { value = 10; }
                else if (value < 0)
                { value = 0; }
                mBitter = value;
                updateItem();
            }
        }
        public double Spice
        {
            get { return mSpice; }
            set 
            {
                if (value > 10)
                { value = 10; }
                else if (value < 0)
                { value = 0; }
                mSpice = value;
                updateItem();
            }
        }

    }
}
