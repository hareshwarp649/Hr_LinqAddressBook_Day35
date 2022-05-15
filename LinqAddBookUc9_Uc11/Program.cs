using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAddBookUc9_Uc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Linq");
            AddBookData adb = new AddBookData();
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
            addressBook.Columns.Add("RelationType");
            Console.WriteLine("\nAddress Book Data Table Created");

            //UC 3 Insert
            adb.AddToTable(addressBook);

            //UC 4 Edit
            //adb.EditRecord(addressBook);

            //UC 5 Delete
            //adb.DeleteRecords(addressBook);

            //Uc 6 Retrieve based on City or State
            //adb.RetievebyCity(addressBook);

            //Uc 7 Count based on City or State
            //adb.CountCityOrState(addressBook);

            //UC 8 Retrieve Records of Searched City and State in Ascending order of FirstName
            //adb.NamesAlpabeticallybyGivenCityandState(addressBook);

            //UC 9 add RelationType Column and Print Name and RealtionType
            //adb.FamilyandFriend(addressBook);

            //Uc 10 Count based in Relation Type
            adb.CountFamilyOrFriend(addressBook);
        }
    }
}
