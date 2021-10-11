using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySix
{
    class Dog
    {
        private int age;
        //auto implemented property
        public string ColourOfFur { get; set; }
        //property backed in a field
        private string breed;
        public string Breed
        {// properties cxall the getters and setters accessors
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        //expression body properties, expression-body accessors
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            
        }
    }
}
