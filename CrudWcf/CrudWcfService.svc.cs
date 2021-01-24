using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace CrudWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CrudWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CrudWcfService.svc or CrudWcfService.svc.cs at the Solution Explorer and start debugging.
    public class CrudWcfService : ICrudWcfService
    {
        Crud cd = new Crud();
        public void CreateFile()
        {
            try
            {
                cd.CreateFile();

            }
            catch (Exception)
            {
            }
        }

        public string ReadFile()
        {
            try
            {
                return cd.ReadFile();
            }
            catch (Exception)
            {
            }
            return "";
        }


        public void UpdateFile(string s)
        {
            try
            {
                cd.UpdateFile(s);

            }

            catch (Exception)
            {
            }

        }


        public void DeleteFile()
        {
            try
            {
                cd.DeleteFile();
            }
            catch (Exception)
            {
            }
        }
    }
}
