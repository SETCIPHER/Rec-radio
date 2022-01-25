using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec_radio
{
    class MyData
    {
        public bool Yes_no = false; // checked 
        private string Year = DateTime.Now.ToString("yyyy");
        private string Month = DateTime.Now.ToString("MM");
        private string Day = DateTime.Now.ToString("dd");
        public string Filename;
        private string Name;

        public string GetInfo()
        {
            return "\\" + Year + "\\" + Month + "\\" + Day + "\\";
        }

        public string GetDirName(string name)
        {

            if (Yes_no == true)
            {
                Name = name + GetInfo();
            }
            else
            {
                Name = name;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(Name);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            return Name;
        }

        public string GetName()
        {
            Filename = DateTime.Now.ToString("HH-mm-ss") + ".mp3";
            //Filename = filename;
            return Name + "\\" + Filename;
        }

        ~MyData()
        {
           
        }

        public void Dispose()
        {
           
        }

    }
}
