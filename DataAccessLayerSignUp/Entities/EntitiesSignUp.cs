using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerSignUp.Entities
{
    public class EntitiesSignUp
    {
        private string id;
        private string firstName;
        private string lastName;
        private string mobileNum;
        private string email;
        private string userName;
        private string gender;
        private string password;
        private string confirmPass;


        public string ID
        {
            set;
            get;
        }
        public string FirstName
        {
            set;
            get;
        }

        public string LastName
        {
            set;
            get;
        }

        public string MobileNum
        {
            set;
            get;
        }

        public string Email
        {
            set;
            get;
        }

        public string UserName
        {
            set;
            get;
        }

        public string Gender
        {
            set;
            get;
        }

        public string Password
        {
            set;
            get;
        }

        public string ConfirmPass
        {
            set;
            get;
        }





    }
}
