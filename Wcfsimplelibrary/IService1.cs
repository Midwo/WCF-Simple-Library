using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfsimplelibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string WelcomeHistory(DataContractIService1WelcomeHistory ALL);

        [OperationContract]
        string DateReturn();


        [OperationContract]
        string SendOrder(DataContractIService1SendOrder data);

        [OperationContract]
        string ReadText();
    }


    }
