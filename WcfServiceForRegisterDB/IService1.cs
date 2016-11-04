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
        #region Persons
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable viewALL();
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable deleteEntry(int inputUserID_ToDelete);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable UpdateEntry(String LastName,String FirstName, String UserName, String Password, String Address, String City ,int Authority,int input_ID_toEdit);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable AddEntry(String LastName,String FirstName,String UserName,String Password, String Address,String City,int Authority);
      
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonsDataTable UserViewOnly();

        #endregion Person
        #region Authority
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons._AuthorityLevel_Update_InsertDataTable UpdateAuthority(String newAuthorityName,int newAccessLevel , int inputID_toUpdate);
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons._AuthorityLevel_Update_InsertDataTable InsertAuthority(String newAuthorityName, int newAccessLevel);

        #endregion Authority

        #region VIEWALLTABLE
        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable VIEWALLFILES();

        [OperationContract]
        ClassLibraryForRegisterDB.DataSet_Persons.PersonAndAuthorityDataTable verify(String Username , String Password);
        #endregion VIEWALLTABLE


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
