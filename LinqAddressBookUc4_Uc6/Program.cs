using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAddressBookUc4_Uc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Linq");
            LinqAddBookDataTable adb = new LinqAddBookDataTable();
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
            adb.AddToTable(addressBook);

            //UC 4 Edit
            adb.EditRecord(addressBook);

            //UC 5 Delete
            adb.DeleteRecords(addressBook);

            //Uc 6 Retrieve based on City or State
            adb.RetievebyCity(addressBook);

        }
    }
}
