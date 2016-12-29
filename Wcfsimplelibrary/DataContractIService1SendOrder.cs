using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcfsimplelibrary
{

    [DataContract]
    public  class DataContractIService1SendOrder
    {
        bool finishorder = true;
        string clientname = "NONE";
        string adressinfomation = "NONE";
        string country = "NONE";
        string value1 = "NONE";
        string optionsend = "NONE";
        string itemname = "NONE";
        string emailclient = "NONE";

        [DataMember]
        public bool Finishorder
        {
            get { return finishorder; }
            set { finishorder = value; }
        }
        [DataMember]
        public string Clientname
        {
            get { return clientname; }
            set { clientname = value; }
        }
        [DataMember]
        public string Adressinfomation
        {
            get { return adressinfomation; }
            set { adressinfomation = value; }
        }
        [DataMember]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        [DataMember]
        public string Value
        {
            get { return value1; }
            set { value1 = value; }
        }
        [DataMember]
             public string Optionsend
        {
            get { return optionsend; }
            set { optionsend = value; }
        }

        [DataMember]
        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }
        [DataMember]
        public string Emailclient
        {
            get { return emailclient; }
            set { emailclient = value; }
        }
    }
}
