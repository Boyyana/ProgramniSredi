using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
	public class User
	{
		private String _username;
		public String username
		{
			get; set;
		}
		private String _password;
		public String password
		{
			get; set;
		}
		private String _fNumber;
		public String fNumber
		{
			get; set;
		}
		private UserRoles _role;
		public UserRoles role
		{
			get; set;
		}
		public DateTime? created { get; set; }
		public DateTime? isActive { get; set; }


		public User(String username1, String password1, String fNumber1, UserRoles Role1, DateTime created, DateTime isActive)
		{
			this.username = username1;
			this.password = password1;
			this.fNumber = fNumber1;
			this.role = Role1;
			this.created = created;
			this.isActive = isActive;

		}
		public DateTime Created;
		public User() { }
	}

}
