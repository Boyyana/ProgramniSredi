using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers = new List<User>();

        public static List<User> testUsers
        {
            get
            {
                resetUserData();
                return _testUsers;
            }
            set { }
        }

        public static void resetUserData()
        {
            if (!_testUsers.Any())
            {
                _testUsers.Add(FillUser(UserRoles.ADMIN));

                for (short i = 1; i < 2; i++)
                {
                    _testUsers.Add(FillUser(UserRoles.STUDENT));
                }
            }
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            /*  foreach (User user in testUsers)
              {
                  if (username.Equals(user.username) && password.Equals(user.password))
                  {
                      return user;
                  }
              }
              return null; */
            User user = (from u in testUsers
                         where u.username.Equals(username) &&
                               u.password.Equals(password)
                         select u).FirstOrDefault();
            return user;
        }
        public static User getUserByUsername(string username)
        {
            foreach (User user in testUsers)
            {
                if (username.Equals(user.username))
                {
                    return user;
                }
            }
            return null;
        }

        private static User FillUser(UserRoles role)
        {
            User user = new User();
            Console.WriteLine("Enter username and password: ");
            user.username = Console.ReadLine();
            user.password = Console.ReadLine();
            Console.WriteLine("Enter your faculty number:");
            user.fNumber = Console.ReadLine();
            user.role = role;
            user.Created = DateTime.MaxValue;
            return user;
        }
        public static void SetUserActiveTo(string username, DateTime date)
        {
            foreach (User user in testUsers)
            {
                if (username.Equals(user.username))
                {
                    Logger.LogActivity("Промяна на активност на " + username);
                    user.Created = date;
                    break;
                }
            }
        }

        public static void seeAllUsers()
        {
            foreach (User user in _testUsers)
            {
                Console.WriteLine(user.username);
            }
        }

        public static void AssignUserRole(string username, UserRoles role)
        {
            foreach (User user in testUsers)
            {
                if (username.Equals(user.username))
                {
                    Logger.LogActivity("Промяна на роля на " + username);
                    user.role = role;
                    break;
                }
            }
        }
    }
}