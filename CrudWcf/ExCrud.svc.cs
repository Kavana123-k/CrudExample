using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrudWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExCrud" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ExCrud.svc or ExCrud.svc.cs at the Solution Explorer and start debugging.
    public class ExCrud : IExCrud
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }
    }
}
