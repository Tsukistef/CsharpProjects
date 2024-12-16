using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercise
{
    internal class Teacher : Person
    {
        public void GenerateTeacherIdNum()
        {
            _idNumber = "TCH" + RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
    }
}
