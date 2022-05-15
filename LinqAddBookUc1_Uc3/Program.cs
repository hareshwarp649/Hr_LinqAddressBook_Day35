using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAddBookUc1_Uc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Linq");
            AddBookDataTable adb = new AddBookDataTable();
            //UC 1 and 2 Create Address Book DataTable
            DataTable addressBook = new DataTable();
            addressBook.TableName = "AddressBook";
            addressBook.Columns.Add("First Name");
            addressBook.Columns.Add("Last Name");
            addressBook.Columns.Add("Address");
            addressBook.Columns.Add("City");
            addressBook.Columns.Add("State");
            addressBook.Columns.Add("Phone Number");
            addressBook.Columns.Add("Email");
            Console.WriteLine("\nAddress Book Data Table Created");

            //UC 3 Insert
            adb.AddToTable(addressBook);

        }
    }
}
