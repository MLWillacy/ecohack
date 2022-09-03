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
    }
}
