using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq35AddBoolUc7_Uc8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Address Book Linq");
            AddBookDataTable atom = new AddBookDataTable();
            //UC 1 and 2 Create Address Book DataTable
            DataTable addressBook = new DataTable();
            addressBook.TableName = "AddressBook";
            addressBook.Columns.Add("FirstName");
            addressBook.Columns.Add("LastName");
            addressBook.Columns.Add("Address");
            addressBook.Columns.Add("City");
            addressBook.Columns.Add("State");
            addressBook.Columns.Add("PhoneNumber");
            addressBook.Columns.Add("Email");
            Console.WriteLine("\nAddress Book Data Table Created");

            //UC 3 Insert
            atom.AddToTable(addressBook);

            //UC 4 Edit
            atom.EditRecord(addressBook);

            //UC 5 Delete
            atom.DeleteRecords(addressBook);

            //Uc 6 Retrieve based on City or State
            atom.RetievebyCity(addressBook);

            //Uc 7 Count based on City or State
            atom.CountCityOrState(addressBook);

            //UC 8 Retrieve Records of Searched City and State in Ascending order of FirstName
            atom.NamesAlpabeticallybyGivenCityandState(addressBook);
        }
    }
    
}
