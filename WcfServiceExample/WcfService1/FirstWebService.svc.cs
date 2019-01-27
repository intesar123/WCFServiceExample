using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWebService.svc or FirstWebService.svc.cs at the Solution Explorer and start debugging.
    //Note: Go to C:\ProgramData\Microsoft\Crypto\RSA give read/write permission of folder 'MachineKeys' to users
    public class FirstWebService : IFirstWebService
    {
        public string Message()
        {
            return "This is my first web service"; //ServiceSecurityContext.Current.PrimaryIdentity.Name.ToString();
        }
    }
}
