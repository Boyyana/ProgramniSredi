using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private String _username;
        private String _password;
        private String _errorMessage;
        private ActionOnError _actionOnError;


        public static string username
        {
            get
            {
                return username;
            }

        }
        public delegate void ActionOnError(string errorMSg);
        public LoginValidation(string name, string password, ActionOnError _actionOnError)
        {
            this._username = name;
            this._password = password;
            this._actionOnError = _actionOnError;
        }
        public static UserRoles currentUserRole
        {
            get; private set;
        }
        public static UserRoles getRole()
        {
            return currentUserRole;
        }
        public bool ValidateUserInput(ref User user)
        {
            Boolean emptyUserName;
            emptyUserName = _username.Equals(String.Empty);
            if (emptyUserName == true)
            {
                _errorMessage = "Username not entered";
                _actionOnError(_errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = _password.Equals(String.Empty);
            if (emptyPassword == true)
            {
                _errorMessage = "Password not entered";
                _actionOnError(_errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (_username.Length < 5 || _password.Length < 5)
            {
                _errorMessage = "Username || password < 5 ! try again";
                _actionOnError(_errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            currentUserRole = UserRoles.ADMIN;
            currentUserRole = (UserRoles)user.role;
            return true;
        }

    }

}