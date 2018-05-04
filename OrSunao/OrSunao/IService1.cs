﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OrSunao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool SIsOfflineUser(string myemail);
        [OperationContract]
        void SOfflineUser(string myemail);
        [OperationContract]
        bool SConnectwithuser(string myemail,string hisemail);
        [OperationContract]
        bool SDeleteUser(string email, string password);
        [OperationContract]
        bool SSuspendUser(string email, string password);

        [OperationContract]
        void getUsersContacts(string email, ref List<string> str);

        [OperationContract]
        void SPassRegisteredUsersname(ref List<string> str);
        [OperationContract]
        void SPassRegisteredUserspassword(ref List<string> str);

        [OperationContract]
        void SPassSuspendedUsersname(ref List<string> str);
        [OperationContract]
        void SPassSuspendedUserspassword(ref List<string> str);
        [OperationContract]
        void SPassToBeRegisteredUsersname(ref List<string> str);
        [OperationContract]
        void SPassToBeRegisteredUserspassword(ref List<string> str);


        [OperationContract]
        bool SRegisterUser(string firstname, string lastname, string password, string email, string contact, string cnic, string secretq, string ans);


        [OperationContract]
        bool SLoginUser(string email, string password);

        [OperationContract]
        bool SPassUser(string email, string password);

        [OperationContract]

        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        bool SRegisterAdmin(string UserFirstName, string UserLastName, string Password, string Email, string CNIC, string Contact);

        [OperationContract]
        bool SLoginAdmin(string Email, string Password);

        [OperationContract]
        bool DeactivateMyAccount(string email, string password);

        [OperationContract]
        void AddToContacts(string myEmail, string myPassword, string hisEmail, string hisPassword);


  

        [OperationContract]
        void AddToBlockedUsers(string myEmail, string hisEmail);


        // TODO: Add your service operations here
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
