﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrSunao
{
    public class Admin : Person
    {
        public bool RegisterAdmin(string UserFirstName, string UserLastName, string Password, string Email, string CNIC, string Contact)
        {
            if (UserDl.adminExist == false)
            {
                this.FirstName = UserFirstName;
                this.LastName = UserLastName;
                this.Password = Password;
                this.Email = Email;
                this.CNIC = CNIC;
                this.ContactNumber = Contact;
                UserDl.adminExist = true;
                UserDl.adminUtill = this;
                return true;
            }
            return false;
        }

        public bool LoginAdmin(string Email, string Password)
        {
            if (UserDl.adminUtill != null)
            {
                if (UserDl.adminUtill.Email == Email && UserDl.adminUtill.Password == Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool SuspendUser(User u)
        {
            return false;
        }

        public bool ApproveRegistration(User u)
        {
            return false;
        }

        public bool ApproveToChat(User u)
        {
            return false;
        }
        public bool ViewRecord(User u)
        {
            return false;
        }

        public bool UpdateRecord(User u)
        {
            return false;
        }










    }
}