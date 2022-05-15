using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAddBookUc1_Uc3
{
    internal class AddBookDataTable
    {
        public void AddToTable(DataTable addressBook)
        {
            addressBook.TableName = "AddressBook";
            //Adding FirstName ,LastName,Address,City,State,PhoneNumber and Email.
            addressBook.Rows.Add("Manoj", "Thiparapu", "25-4-710", "Kazipet", "Telangana", "8106529025", "manojthiparapu@gmail.com");
            addressBook.Rows.Add("Eren", "Jeager", "Shinsengumi", "Wall Maria", "Attak on Titan", "7958977310", "erenjeager@gmail.com");
            addressBook.Rows.Add("Sasuke", "Uchiha", "4-3-333", "Leaf Village", "Naruto", "9106529025", "schihasasuke@gmail.com");
            addressBook.Rows.Add("Kamado", "Tanjiro", "mt Kumotori", "Okutama", "Demon Slayer", "7578977310", "kamadoTanjiro@gmail.com");

            foreach (DataRow row in addressBook.Rows)
            {
                string firstName = row["First Name"].ToString();
                string lastName = row["Last Name"].ToString();
                string address = row["Address"].ToString();
                string city = row["City"].ToString();
                string state = row["State"].ToString();
                string phoneNumber = row["Phone Number"].ToString();
                string email = row["Email"].ToString();
                Console.WriteLine("\nFirst Name : " + firstName + ", Last Name : " + lastName + ", Address : " + address + ", City : " + city + ", State : " + state +
                    ", Phone Number : " + phoneNumber + ", Email : " + email);
            }
        }
    }
}
