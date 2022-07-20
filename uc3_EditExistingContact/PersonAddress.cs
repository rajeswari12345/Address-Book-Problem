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
        public void AddContact()
        {
            Console.WriteLine("Enter Firstname");
            string? FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string? LastName = Console.ReadLine();
            Console.WriteLine("Enter City");
            string? City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string? State = Console.ReadLine();
            Console.WriteLine("Enter zip Number");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            string? Email = Console.ReadLine();
            Contact ContactPer = new Contact()
            {
                FirstName = FirstName,
                LastName = LastName,
                City = City,
                State = State,
                Zip = Zip,
                PhoneNumber = PhoneNumber,
                Email = Email,
            };
            persons.Add(ContactPer.FirstName, ContactPer);
            ForDisplay();
        }
        public void EditContact()
        {
            Console.WriteLine("If want to edit contact press 0 , else press any keyword ");
            int editCon = Convert.ToInt32(Console.ReadLine());
            switch (editCon)
            {
                case 0:
                    //only edit the added contact
                    Console.WriteLine("To edit contact list enter First Name");
                    string name = Console.ReadLine().ToLower();

                    Contact cust;
                    if (persons.TryGetValue(name, out cust))
                    {
                        Console.WriteLine("enter the information wants to edit");
                        Console.WriteLine("For edit First Name enter - 0");
                        Console.WriteLine("For edit Last Name enter - 1");
                        Console.WriteLine("For edit City  enter - 2");
                        Console.WriteLine("For edit State  enter - 3");
                        Console.WriteLine("For edit Zip  enter - 4");
                        Console.WriteLine("For edit Phone  enter - 5");
                        Console.WriteLine("For edit Email  enter - 6");
                        int edit = Convert.ToInt32(Console.ReadLine());
                        switch (edit)
                        {
                            case 0:
                                Console.WriteLine("Enter the First Name");
                                cust.FirstName = Console.ReadLine();
                                break;
                            case 1:
                                Console.WriteLine("Enter the Last Name");
                                cust.LastName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter city Name");
                                cust.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter State Name");
                                cust.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter Zip ");
                                cust.Zip = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter Phone Number");
                                cust.PhoneNumber = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Email");
                                cust.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Contact not exixt");
                                break;
                        }
                    }
                    ForDisplay();
                    break;
                default:
                    Console.WriteLine("Do Not want to edit");
                    break;
            }
        }
    }
}