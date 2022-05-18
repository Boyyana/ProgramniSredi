using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            StudentData studentData = new StudentData();
           if(user == null || user.fNumber == null)
            {
                throw new ArgumentNullException("Nqma potrebitel s takuv fNumber!");
            } 

           IEnumerable<Student> list = studentData.GetStudents();

           foreach(Student st in list)
            {
                if (st.FacultyNumber.Equals(user.fNumber))
                {
                    return st;
                }
            }

            throw new ArgumentNullException("Nqma takuv student");

        }
    }
}
