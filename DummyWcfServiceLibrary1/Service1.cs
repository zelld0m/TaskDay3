using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using ClassLibraryForRegisterDB;

namespace DummyWcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        #region Declaration
        ClassLibraryForRegisterDB.DAL DAL = new ClassLibraryForRegisterDB.DAL();
        DataTable dt = new DataTable();
        #endregion Declaration
        #region COding

        DAL IService1.DummyAdd(string name)
        {
            DAL.AddDummy(name);
            throw new NotImplementedException();
        }

        DAL IService1.DummyDelete(int inputID)
        {
            DAL.DeleteDummy(inputID);
            throw new NotImplementedException();
        }

        DataTable IService1.DummySearch(string inputname)
        {
           
             dt = DAL.SearchDummy(inputname);
            return dt;
            throw new NotImplementedException();
        }

        DAL IService1.DummyUpdate(int inputID, string name)
        {
            DAL.UpdateDummy(inputID, name);
            throw new NotImplementedException();
        }

        DataTable IService1.DummyViewALL()
        {
            dt = DAL.ViewDummy();
            return dt;

            throw new NotImplementedException();
        }
#endregion Codings
        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
