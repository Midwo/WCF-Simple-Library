using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wcfsimplelibrary
{
    [DataContract]
    public class DataContractIService1WelcomeHistory
    {
        bool agentAction = true;
        string author = "NONE";
        string message = "NONE";

        [DataMember]
        public bool AgentAction
        {
            get { return agentAction; }
            set { agentAction = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        [DataMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

    }
}
