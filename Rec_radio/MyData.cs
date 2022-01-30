using System;
using System.IO;


namespace Rec_radio
{
    class MyData
    {
        public bool yes_no = false; // checked 
        private string year = DateTime.Now.ToString("yyyy");
        private string month = DateTime.Now.ToString("MM");
        private string day = DateTime.Now.ToString("dd");
        public string fileName;
        private string dirName;

        public string get_Info()
        {
            return "\\" + year + "\\" + month + "\\" + day + "\\";
        }

        public string getDirName(string name)
        {

            if (yes_no == true)
            {
                dirName = name + get_Info();
            }
            else
            {
                dirName = name;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            return dirName;
        }

        public string getName()
        {
            fileName = DateTime.Now.ToString("HH-mm-ss") + ".mp3";
            //Filename = filename;
            return dirName + "\\" + fileName;
        }

        ~MyData()
        {
           
        }

        public void Dispose()
        {
           
        }

    }
}
