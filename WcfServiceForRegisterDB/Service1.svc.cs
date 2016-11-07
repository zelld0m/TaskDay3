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

        ClassLibraryForRegisterDB.DataSet_Persons._AuthorityLevel_Update_InsertDataTable dt_Authority = new DataSet_Persons._AuthorityLevel_Update_InsertDataTable();
        ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.AuthorityLevel_Update_InsertTableAdapter da_Authority = new ClassLibraryForRegisterDB.DataSet_PersonsTableAdapters.AuthorityLevel_Update_InsertTableAdapter();

        #endregion declarationOfDataAdaptor and Datasets


        #region Personal DataTable
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

        DataSet_Persons.PersonsDataTable IService1.UpdateEntry(string LastName, string FirstName, string UserName, string Password, string Address, string City, int Authority, int input_ID_toEdit)
        {
            da.UpdateRegistrationQuery(LastName, FirstName, UserName, Password, Address, City,Authority, input_ID_toEdit);
            return dt;
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonsDataTable IService1.AddEntry(string LastName, string FirstName, string UserName, string Password, string Address, string City,int AuthorityLevel)
        {

            da.InsertRegistrationQuery(LastName, FirstName, UserName, Password, Address, City,AuthorityLevel);
            return dt;
            throw new NotImplementedException();
        }

        

        DataSet_Persons.PersonsDataTable IService1.UserViewOnly()
        {
            da.ViewUsersOnly(dt);
            return dt;
            throw new NotImplementedException();
        }

        #endregion PersonalDataTable

        #region AuthorityLEvel
        DataSet_Persons._AuthorityLevel_Update_InsertDataTable IService1.UpdateAuthority(string newAuthorityName, int newAccessLevel, int inputID_toUpdate)
        {

            da_Authority.UpdateAuthorityLevel(dt_Authority, newAuthorityName, newAccessLevel, inputID_toUpdate);
            throw new NotImplementedException();
        }

        DataSet_Persons._AuthorityLevel_Update_InsertDataTable IService1.InsertAuthority(string newAuthorityName, int newAccessLevel)
        {

            da_Authority.InsertNewAuthority(newAuthorityName, newAccessLevel);
            throw new NotImplementedException();
        }
        #endregion AuthorityLEvel


        #region Personal And Authority View Only
        DataSet_Persons.PersonAndAuthorityDataTable IService1.VIEWALLFILES()
        {
            
            da_personAndAuthority.FillViewPersonAndAuthority(dt_personAndAuthority);
            return dt_personAndAuthority;
            
            throw new NotImplementedException();
        }

        DataSet_Persons.PersonAndAuthorityDataTable IService1.verify(String UserName , String Password)
        {

            
             da_personAndAuthority.FillVerify(dt_personAndAuthority,UserName,Password);
            return dt_personAndAuthority;
            
            throw new NotImplementedException();
        }


        #endregion Personal And Authority View Only




        #endregion EndDBcode
    }
}
