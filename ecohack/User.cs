using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecohack
{
    public class User
    {
        string mName;
        int mPound = 0;
        int mPence = 0;
        int mScore = 0;

        float mSalty;
        float mSweet;
        float mSour;
        float mBitter;
        float mSpice;

        public User(string pName)
        {
            mName = pName;
        }

        public string Name
        {
            get { return mName; }
        }

        public int Pound
        {
            get { return mPound; }
        }

        public int Pence
        {
            get { return mPence; }
            set 
            { 
                mPence = value; 
                if (mPence > 99)
                {
                    mPound++;
                    mPence = mPence - 99;
                }
            }
        }

        public float Salty
        {
            get { return mSalty; }
            set { mSalty = value; }
        }

        public float Sweet
        {
            get { return mSweet; }
            set { mSweet = value; }
        }

        public float Sour
        {
            get { return mSour; }
            set { mSour = value; }
        }
        public float Bitter
        {
            get { return mBitter; }
            set { mBitter = value; }
        }
        public float Spice
        {
            get { return mSpice; }
            set { mSpice = value; }
        }

        public int Score
        {
            get { return mScore; }
            set { mScore = value; }
        }
    }
}
