using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAddressBookUc4_Uc6
{
    internal class LinqAddBookDataTable
    {
        //UC 3 Insert New Contact to Address Book
        public void AddToTable(DataTable addressBook)
        {
            addressBook.TableName = "AddressBook";
            //Adding FirstName ,LastName,Address,City,State,PhoneNumber and Email.
            addressBook.Rows.Add("Manoj", "Thiparapu", "25-4-710", "Kazipet", "Telangana", "8106529025", "manojthiparapu@gmail.com");
            addressBook.Rows.Add("Eren", "Jeager", "Shinsengumi", "Wall Maria", "Attak on Titan", "7958977310", "erenjeager@gmail.com");
            addressBook.Rows.Add("Sasuke", "Uchiha", "4-3-333", "Leaf Village", "Naruto", "9106529025", "schihasasuke@gmail.com");
            addressBook.Rows.Add("Kamado", "Tanjiro", "mt Kumotori", "Okutama", "Demon Slayer", "7578977310", "kamadoTanjiro@gmail.com");
            Display(addressBook);
        }

        public void Display(DataTable addressBook)
        {
            foreach (DataRow row in addressBook.Rows)
            {
                string firstName = row["FirstName"].ToString();
                string lastName = row["LastName"].ToString();
                string address = row["Address"].ToString();
                string city = row["City"].ToString();
                string state = row["State"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();
                string email = row["Email"].ToString();
                Console.WriteLine("\nFirst Name : " + firstName + ", Last Name : " + lastName + ", Address : " + address + ", City : " + city + ", State : " + state +
                    ", Phone Number : " + phoneNumber + ", Email : " + email);
            }
        }
        //UC 4 
        public void EditRecord(DataTable addressBook)
        {

            Console.WriteLine("\nEnter a Name to Search");
            string fname = Console.ReadLine();
            foreach (DataRow row in addressBook.Rows)
            {

                if (Convert.ToString(row["FirstName"]) == fname)
                {
                    Console.WriteLine("Enter First Name to Replace all the row values");
                    row["FirstName"] = Console.ReadLine();
                    Console.WriteLine("Enter LastName");
                    row["LastName"] = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    row["Address"] = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    row["City"] = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    row["State"] = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    row["PhoneNumber"] = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    row["Email"] = Console.ReadLine();
                    addressBook.AcceptChanges();
                }
            }
            Console.WriteLine("\nDisplay AddressBook After Changes");

            Display(addressBook);
        }

        //UC 5 Delete
        public void DeleteRecords(DataTable addressBook)
        {
            Console.WriteLine("\nEnter a Name to Search");
            string fname = Console.ReadLine();
            for (int i = 0; i < addressBook.Rows.Count; i++)
            {
                DataRow dr = addressBook.Rows[i];
                if (Convert.ToString(dr["FirstName"]) == fname)
                {
                    dr.Delete();
                    addressBook.AcceptChanges();
                }
            }
            Console.WriteLine("\nDisplay AddressBook After Changes");
            Display(addressBook);
        }
        //Uc 6 Retrieve Based on City or State
        public void RetievebyCity(DataTable addressBook)
        {
            Console.WriteLine("\n Enter City to Search and Retrieve Records");
            string city = Console.ReadLine();
            foreach (DataRow row in addressBook.Rows)
            {
                if (Convert.ToString(row["City"]) == city)
                {
                    string fname = row["FirstName"].ToString();
                    string lname = row["LastName"].ToString();
                    string address = row["Address"].ToString();
                    string city1 = row["City"].ToString();
                    string state = row["State"].ToString();
                    string phno = row["PhoneNumber"].ToString();
                    string email = row["Email"].ToString();
                    Console.WriteLine("person in " + city + " this city are : \n" + "First Name : " + fname + ", Last Name : " + lname + ", Address : " + address + ", City : " + city1 + ", State : " + state + ", PhoneNumeber : " + phno + ", Email : " + email);
                }
            }
            Console.WriteLine("\n Enter State to Search and Retrieve REcords");
            string state1 = Console.ReadLine();
            foreach (DataRow row1 in addressBook.Rows)
            {
                if (Convert.ToString(row1["State"]) == state1)
                {
                    string fname1 = row1["FirstName"].ToString();
                    string lname1 = row1["LastName"].ToString();
                    string address1 = row1["Address"].ToString();
                    string city1 = row1["City"].ToString();
                    string state2 = row1["State"].ToString();
                    string phno1 = row1["PhoneNumber"].ToString();
                    string email1 = row1["Email"].ToString();
                    Console.WriteLine("person in " + state1 + " this State are : \n" + "First Name : " + fname1 + ", Last Name : " + lname1 + ", Address : " + address1 + ", City : " + city1 + ", State : " + state2 + ", PhoneNumeber : " + phno1 + ", Email : " + email1);
                }
            }
        }
    }
}
