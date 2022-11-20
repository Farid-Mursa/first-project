using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Info
{
    internal class Student
    {
        public string Ad;
        public string Soyad;
        public string Qrup;
        public byte Bal;
        public bool Oxuyur;


        public Student(string name, string surname, string group, byte bal, bool oxuyur)
        {
            Ad = name;
            Soyad = surname;
            Qrup = group;
            Bal = bal;
            Oxuyur = oxuyur;

            if (oxuyur)
            {
                Console.WriteLine("FullName: " + name + " " + surname);
                Console.WriteLine("Qrup: " + group);
                Console.WriteLine("Bal: " + bal);
                Console.WriteLine("Siz oxuyursunuz");
            }
            else
            {
                Console.WriteLine("Siz oxumursuznuz");
            }
        }

        public Student(string name, string surname, string group, byte bal)
        {
            Ad = name;
            Soyad = surname;
            Qrup = group;
            Bal = bal;

            if (bal > 80 && bal <= 100)
            {
                Console.WriteLine(name + " " + surname + " Siz ikinci imtahana gire bilersiniz");
            }
            else if (bal <= 80)
            {
                Console.WriteLine(name + " " + surname + " Siz ikinci imtahana gire bilmersiniz");
            }
            else
            {
                Console.WriteLine("Please enter a valid point value");
            }
        }
    }
}
