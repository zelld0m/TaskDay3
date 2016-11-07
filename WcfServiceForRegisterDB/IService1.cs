using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceForRegisterDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        #region Persons   =0=================================================================

        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable viewALL();
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable deleteEntry(int inputUserID_ToDelete);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable _insertPerson(String LastName, String FirstName, String UserName, String Password, String Address);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable UpdateEntry(String LastName,String FirstName, String UserName, String Password, String Address , int user_ID_to_update);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable UserViewOnly();

        #endregion Person   =0=================================================================
        
        #region Authority


          [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable _VIEWALLFILES();

        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable _UpdateAuthority(String newAuthorityName, int newAccessLevel, int input_P_ID_toUpdate);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable _InsertAuthority(String newAuthorityName, int newAccessLevel);

        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable _verify(String Username , String Password);
       
        #endregion Authority

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
