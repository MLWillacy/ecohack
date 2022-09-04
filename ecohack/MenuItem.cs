using System;
using System.CodeDom.Compiler;
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
        double mUserScore;

        public MenuItem(string pTitle, string pAuthor, float pRating, string pDescription, string pTastes, string pPath, User pUser)
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

            double tempScore;

            if (pUser.Salty > mSalty)
            { tempScore = pUser.Salty - mSalty; }
            else { tempScore = mSalty - pUser.Salty; }

            if (pUser.Sweet > mSweet)
            { tempScore = tempScore + pUser.Sweet - mSweet; }
            else { tempScore = mSweet - pUser.Sweet; }

            if (pUser.Sour > mSour)
            { tempScore = tempScore + pUser.Sour - mSour; }
            else { tempScore = mSour - pUser.Sour; }

            if (pUser.Bitter > mBitter)
            { tempScore = tempScore + pUser.Bitter - mBitter; }
            else { tempScore = mBitter - pUser.Bitter; }

            if (pUser.Spice > mSpice)
            { tempScore = tempScore + pUser.Spice - mSpice; }
            else { tempScore = mSpice - pUser.Spice; }

            mUserScore = tempScore * mRating;
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

        public double Score
        { get { return mUserScore; } }

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
