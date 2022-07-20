using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class PersonAddress
    {
        public Dictionary<string, Contact> persons = new Dictionary<string, Contact>();
        public void Book()
        {
            Contact PersonsOneCon = new Contact() { FirstName = "Vijay", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 8000001, PhoneNumber = 87654321287, Email = "vijya87348@gmail.com" };
            Contact PersonsTwoCon = new Contact() { FirstName = "Nitish", LastName = "kumar", City = "Patna", State = "Bihar", Zip = 800005, PhoneNumber = 654321287, Email = "vijya87348@gmail.com" };
            Contact PersonsThreeCon = new Contact() { FirstName = "Rahul ", LastName = "Yadav", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 43523254234, Email = "rahul@gmail.com" };
            Contact PersonsFourCon = new Contact() { FirstName = "Rohal ", LastName = "Goyal", City = "Delhi", State = "New Delhi", Zip = 534342, PhoneNumber = 76523254234, Email = "rohan@gmail.com" };
            persons.Add(PersonsOneCon.FirstName, PersonsOneCon);
            persons.Add(PersonsTwoCon.FirstName, PersonsTwoCon);
            persons.Add(PersonsThreeCon.FirstName, PersonsThreeCon);
            persons.Add(PersonsFourCon.FirstName, PersonsFourCon);
            ForDisplay();
        }
        public void ForDisplay()
        {
            foreach (KeyValuePair<string, Contact> CustomerContact in persons)
            {
                Contact custContct = CustomerContact.Value;
                Console.WriteLine("Your name is :{0} ", custContct.FirstName + " " + custContct.LastName);
                Console.WriteLine("Your City: {0}", custContct.City);
                Console.WriteLine("Your State: {0}", custContct.State);
                Console.WriteLine("Your Zip:{0}", custContct.Zip);
                Console.WriteLine("Your PhoneNumber: {0}", custContct.PhoneNumber);
                Console.WriteLine("Email: {0}", custContct.Email);
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}