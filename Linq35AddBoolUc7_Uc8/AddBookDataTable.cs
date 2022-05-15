using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq35AddBoolUc7_Uc8
{
    internal class AddBookDataTable
    {

        public void AddToTable(DataTable addressBook)
        {
            addressBook.TableName = "AddressBook";
            //Adding FirstName ,LastName,Address,City,State,PhoneNumber and Email.
            addressBook.Rows.Add("Deva", "Rathi", "25-4-710", "Kazipet", "Telangana", "8106529025", "manojthiparapu@gmail.com");
            addressBook.Rows.Add("Veda ", "More", "Shinsengumi", "Kazipet", "Attak on Titan", "7958977310", "erenjeager@gmail.com");
            addressBook.Rows.Add("Vijay", "Patil", "4-3-333", "Leaf Village", "Naruto", "9106529025", "schihasasuke@gmail.com");
            addressBook.Rows.Add("Niba", "Ranga", "mt Kumotori", "Okutama", "Telangana", "7578977310", "kamadoTanjiro@gmail.com");
            Display(addressBook);
        }

        public void Display(DataTable addressBook)
        {
            foreach (DataRow row in addressBook.Rows)
            {

                Console.WriteLine("\nFirst Name : " + row[0] + ", Last Name : " + row[1] + ", Address : " + row[2] + ", City : " + row[3] + ", State : " + row[4] +
                    ", Phone Number : " + row[5] + ", Email : " + row[6]);
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
            Console.WriteLine("\n Enter State to Search and Retrieve Records");
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
        //UC 7 Count records based on City and State
        public int numberOfRecordsCity, numberOfRecordsState;
        public void CountCityOrState(DataTable addressBook)
        {
            Console.WriteLine("\n Enter City to Search and Retrieve Records");
            string city = Console.ReadLine();
            foreach (DataRow row in addressBook.Rows)
            {
                if (Convert.ToString(row["City"]) == city)
                {
                    numberOfRecordsCity = addressBook.AsEnumerable().Where(x => x["City"].ToString() == city).ToList().Count;

                }

            }
            Console.WriteLine(numberOfRecordsCity);
            Console.WriteLine("\n Enter State to Search and Retrieve Records");
            string state = Console.ReadLine();
            foreach (DataRow row in addressBook.Rows)
            {
                if (Convert.ToString(row["State"]) == state)
                {
                    numberOfRecordsState = addressBook.AsEnumerable().Where(x => x["State"].ToString() == state).ToList().Count;

                }

            }
            Console.WriteLine(numberOfRecordsState);
        }
        //UC 8 Retrieve Records of Searched City and State in Ascending order of FirstName
        public void NamesAlpabeticallybyGivenCityandState(DataTable addressBook)
        {


            var Rows = from row in addressBook.AsEnumerable() orderby row["FirstName"] ascending select row;
            DataTable addressBook1 = Rows.AsDataView().ToTable();
            PrintCity(addressBook1);
            PrintState(addressBook1);
        }
        public void PrintCity(DataTable addressBook1)
        {
            Console.WriteLine("\nEnter City to Be Searched and Retrieve Rcords by Aplabetical Order of First Name");
            string city = Console.ReadLine();
            foreach (DataRow row in addressBook1.Rows)
            {
                if (Convert.ToString(row["City"]) == city)
                {
                    Console.WriteLine(string.Format("\n{0},{1},{2},{3},{4},{5},{6}", row[0], row[1], row[2], row[3], row[4], row[5], row[6]));
                }
            }
        }
        public void PrintState(DataTable addressBook1)
        {
            Console.WriteLine("\nEnter State to Be Searched and Retrieve Rcords by Aplabetical Order of First Name");
            string state = Console.ReadLine();
            foreach (DataRow row in addressBook1.Rows)
            {
                if (Convert.ToString(row["State"]) == state)
                {
                    Console.WriteLine(string.Format("\n{0},{1},{2},{3},{4},{5},{6}", row[0], row[1], row[2], row[3], row[4], row[5], row[6]));
                }
            }

        }
    }
}
  