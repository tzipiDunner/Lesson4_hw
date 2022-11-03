using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Contact
    {
        public string firstName;
        public string lastName;
        public string EmailAdress;

        public Contact(string firsName,string lastName,string ad)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            EmailAdress = ad;
        }
        public override string ToString()
        {
            return "name: " + firstName + " " + lastName + ",Email: " + EmailAdress;
        }
    }
}
