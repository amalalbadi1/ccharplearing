using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day1
{
    internal class person
    {

        public int id;
        public string fristName;
        public string lastName;
        public int age;
        public string job;
        public string adress;
        public person(int id, string fristName, string lastName, int age, string job, string andres)
        {
            this.id = id;
            this.fristName = fristName;
            this.lastName = lastName;
            this.age = age;
            this.job = job;
            this.adress = adress;
        }

    }
}
