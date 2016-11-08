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
        #region declarationOfDataAdaptor and Datasets
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable dt_personAndAuthority = new DataSet_Persons.PersonAndAuthorityDataTable();
        ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonAndAuthorityTableAdapter da_personAndAuthority = new ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonAndAuthorityTableAdapter();

        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable dt = new ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable();
        ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonsTableAdapter da = new ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.PersonsTableAdapter();

    
        #endregion declarationOfDataAdaptor and Datasets


        #region Personal DataTable
        DataSet_Persons.PersonsDataTable IService1.viewALL()
        { 
            da.Fill_ViewALL(dt);
            return dt;
            throw new NotImplementedException();
        }
        DataSet_Persons.PersonsDataTable IService1.deleteRegisteredPersonQuery(int inputUserID_ToDelete)
        {
            da.DeleteRegisteredPersonQuery(inputUserID_ToDelete);
            return dt;
            throw new NotImplementedException();
        }
        DataSet_Persons.PersonsDataTable IService1.UpdateRegistrationQuery(string LastName, string FirstName, string UserName, string Password, string Address,int user_ID_to_updates)
        {
            da._UpdateRegistrationQuery(LastName, FirstName, UserName, Password,Address, user_ID_to_updates);
            return dt;
            throw new NotImplementedException();
        }
        DataSet_Persons.PersonsDataTable IService1.insertRegistrationQuery(string LastName, string FirstName, string UserName, string Password, string Address)
        {
            da._InsertRegistrationQuery(LastName, FirstName, UserName, Password, Address);
            return dt;
            throw new NotImplementedException();
        }
        DataSet_Persons.PersonsDataTable IService1.ViewUserOnly()
        {
            da.ViewUsersOnly(dt);
            return dt;
            throw new NotImplementedException();
        }

        #endregion PersonalDataTable

     


        #region Personal And Authority View Only
        DataSet_Persons.PersonAndAuthorityDataTable IService1._VIEWALLFILES()
        {
            da_personAndAuthority._FillViewPersonAndAuthority(dt_personAndAuthority);
            return dt_personAndAuthority;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonAndAuthorityDataTable IService1._UpdateAuthority(string newAuthorityName, int newAccessLevel, int input_P_ID_toUpdate)
        {

            da_personAndAuthority._Update_Authority_Query(newAccessLevel, newAuthorityName, input_P_ID_toUpdate);
            return dt_personAndAuthority;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonAndAuthorityDataTable IService1._InsertAuthority(string newAuthorityName, int newAccessLevel)
        {
            da_personAndAuthority._Insert_Registration_Authority( dt_personAndAuthority, newAuthorityName, newAccessLevel);
            return dt_personAndAuthority;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonAndAuthorityDataTable IService1._verify(string Username, string Password)
        {
            da_personAndAuthority._FillVerify(dt_personAndAuthority, Username,Password);
            return dt_personAndAuthority;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonAndAuthorityDataTable IService1._DeleteAuthority(int input_IDtoDelete)
        {
            da_personAndAuthority._DeleteAuthorityQuery(input_IDtoDelete);
            return dt_personAndAuthority;
            throw new NotImplementedException();
        }




        #endregion Personal And Authority View Only




        #endregion EndDBcode
    }
}
