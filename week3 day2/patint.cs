using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace week3_day2
{


    enum Day
    {
        
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Holiday = Friday | Saturday
    }




    internal class patint
    {
        private string Name;
        private int Age;
        private string RelationshipState;
        private string FaristVist;

        
        
        public patint(string name, int age, string relationshipState, string faristVist)
        {
            this.Name = name;
            this.Age = age;
            this.RelationshipState = relationshipState;
            this.FaristVist = faristVist;

        }
        public void choosday(Day day)
        {
            switch ((int)day)
            {

                case 1:    
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                break;
            }

        }

            


    }
}
