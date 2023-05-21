using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebooke
{
    internal class phonebook
    {

        private string[] Name;
        private string[] Number;
        private int Size;
       
        public phonebook(int size)
        {
            this.Size = size;
            this.Name = new string[this.Size];
            this.Number = new string[this.Size];
        }

        public string this[int indx, string name]
        {
            set
            {
                Number[indx] = value;
                Name[indx] = name;
            }
/*
            get
            {
                for (int i = 0; i < this.Size; i++)
                {
                    if (Name[i] == name)
                    {
                        return Number[i];
                    }
                }
                return "NA";
            }
*/
        }
        
        public string this[string name]
        {
            get
            {
                for (int i = 0; i <this.Size; i++)
                {
                    if (Name[i] == name)
                    {
                        return Number[i];
                    }
                }

                return "NA";
            }
        }
        
        /* public void setvalue(int indix , string name, string number)
         {
             if ((indix>0)&&(indix<size)&& (indix>count))
            // for(int i=0; i<number.Length; i++)
             {
                 this.name[indix] = name;
                 this.number[indix] = number;
                 //Console.WriteLine(name);
                 //Console.WriteLine(number);

             }

         }

         public string getvalue(string name)
         {
             for(int i = 0; i < size; i++)
             {
                 if (name[i] == name[i])

                         return number[i];
             }
             return "NA";
         }

     }
        */
    }
}
