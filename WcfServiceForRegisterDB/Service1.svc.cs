using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibraryForRegisterDB;


namespace WcfServiceForRegisterDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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

     

        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }


        #region StartDBcode
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable dt = new ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable();
        ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonsTableAdapter da = new ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonsTableAdapter();

        DataSet_Persons.PersonsDataTable IService1.viewALL()
        { 
            da.Fill_ViewALL(dt);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.deleteEntry(int inputUserID_ToDelete)
        {
            da.DeleteRegisteredPersonQuery(inputUserID_ToDelete);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.UpdateEntry(string LastName, string FirstName, string UserName, string Password, string Address, string City, String Authority, int input_ID_toEdit)
        {
            da.UpdateRegistrationQuery(LastName, FirstName, UserName, Password, Address, City,Authority, input_ID_toEdit);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.AddEntry(string LastName, string FirstName, string UserName, string Password, string Address, string City,String Authority)
        {

            da.InsertRegistrationQuery(LastName, FirstName, UserName, Password, Address, City,Authority);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.verify(string Username, string Password)
        {

            da.VerifyUserAndPassword(dt, Username, Password);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.UserViewOnly()
        {
            da.ViewUsersOnly(dt);
            return dt;
            throw new NotImplementedException();
        }





        #endregion EndDBcode
    }
}
