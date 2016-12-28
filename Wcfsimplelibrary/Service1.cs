using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfsimplelibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string WelcomeHistory(DataContractIService1WelcomeHistory All)
        {
            string path = "MyTest.txt";
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Type: " + All.AgentAction + ", Author: " + All.Author + ", Message: " + All.Message + "");
                }
            }

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Type: " + All.AgentAction + ", Author: " + All.Author + ", Message: " + All.Message + "");
                }
            }
       
            return string.Format("Save in file txt: Type: {0}, Author: {1}, Message {2}", All.AgentAction, All.Author, All.Message);



        }

        public string DateReturn()
        {
           DateTime date = DateTime.Now;
            return date.ToString();
        }

        public string ReadText()
        {
            string path = "MyTest.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string all ="";
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    all += line;
                }
                return all;
            }
        }
    }
}
