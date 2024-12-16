using System.Security.Cryptography;

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
