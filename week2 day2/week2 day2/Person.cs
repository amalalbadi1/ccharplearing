using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace week2_day2
{
    internal class Person
    {

        private string fname;
        private string lname;
        private int age;
        private int yearofbd;
        private int Salary;
        public string relationshipStatues;


        public void setfname(string fname)
        { this.fname = fname; }

        public string getfname()
        {
            return fname;
        }

        public void setlname(string lname) {
        this.lname = lname;
                }
        public string getlname()
        {
            return lname;
        }
        public void setage(int age) {  
            
            this.age = age; }

        public int getage()
        {
            return age;
        }
        public void setSalary(int Salary)
        {

            this.Salary = Salary;
        }

        public int getsalary()
        {
            return Salary;
        }

        public void setrelationshipStatues(string relationshipStatues)
        {
            this.relationshipStatues = relationshipStatues;
        }

        public string getrelationshipStatues()
        {
            return relationshipStatues;
        }
        public void printInfo() {
            Console.WriteLine($"you name {fname} {lname} your age  {age} your salary {Salary} relation {relationshipStatues} ");
        }

        public int age2( int thisyear , int yearofbd) => thisyear-yearofbd;


    }
}
