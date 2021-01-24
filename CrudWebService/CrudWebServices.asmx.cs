using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CrudWebService
{
    /// <summary>
    /// Summary description for CrudWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CrudWebServices : System.Web.Services.WebService
    {
        Crud1 cr = new Crud1();
        [WebMethod]
        public void CreateFile()
        {
            try
            {
                cr.CreateFile();
            }
            catch (Exception)
            {
            }
        }
        [WebMethod]
        public string ReadFile()
        {
            try
            {
                return cr.ReadFile();
            }
            catch (Exception)
            {
            }
            return "";
        }
        [WebMethod]
        public void UpdateFile(string s)
        {
            try
            {
                cr.UpdateFile(s);
            }
            catch (Exception)
            {
            }
        }
        [WebMethod]
        public void DeleteFile()
        {
            try
            {
                cr.DeleteFile();
            }
            catch (Exception)
            {
            }
        }
    }
}
