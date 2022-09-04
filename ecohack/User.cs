using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;

namespace ecohack
{
    public class User
    {
        string mFilePath;

        string mName;
        int mPound = 0;
        int mPence = 0;
        int mScore = 0;

        double mSalty;
        double mSweet;
        double mSour;
        double mBitter;
        double mSpice;

        public User(string pFilepath)
        {
            mFilePath = pFilepath;

            string contents = File.ReadAllText(mFilePath);
            string[] lines = contents.Split('\n');

            string mName = lines[0];
            int mScore = int.Parse(lines[1]);

            string[] balanceSplit = lines[2].Split('.');
            mPound = int.Parse(balanceSplit[0]);
            mPence = int.Parse(balanceSplit[1]);

            string[] tastesSplit = lines[3].Split(',');
            mSalty = float.Parse(tastesSplit[0]);
            mSweet = float.Parse(tastesSplit[1]);
            mSour = float.Parse(tastesSplit[2]);
            mBitter = float.Parse(tastesSplit[3]);
            mSpice = float.Parse(tastesSplit[4]);
        }

        private void updateUser()
        {
            StreamWriter sw = new StreamWriter(mFilePath);

            sw.WriteLine(mName);
            sw.WriteLine(mScore);
            sw.WriteLine(mPound + "." + mPence);
            sw.WriteLine(mSalty + "," + mSweet + "," + mSour + "," + mBitter + "," + mSpice);

            sw.Close();
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
                updateUser();
            }
        }

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
                updateUser(); 
            }

        }

        public double Sweet
        {
            get { return mSweet; }
            set 
            {
                if (value > 10)
                { value = 10; }
                else if (value < 0)
                { value = 0; }
                mSweet = value;
                updateUser();
            }
        }

        public double Sour
        {
            get { return mSour; }
            set 
            {
                if (value > 10)
                { value = 10; }
                else if (value < 0)
                { value = 0; }
                mSour = value;
                updateUser(); 
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
                updateUser(); 
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
                updateUser(); 
            }
        }

        public int Score
        {
            get { return mScore; }
            set { mScore = value; updateUser(); }
        }
    }
}
