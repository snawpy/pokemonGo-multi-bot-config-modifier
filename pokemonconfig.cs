using System;
using System.Xml.Linq;
using System.Xml.XPath;

namespace pokemonGoConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            //add multiple user configs here 
            //@folder path, username, password, lattitude, longitude.
            editUser(@"C:\Users\Snawpy\Downloads\botFolder", "hohoho", "123456", "420", "620");
  
            Console.WriteLine("Users all modified.");
            Console.ReadLine();
        }

        static void editUser(string folderLoc, string username, string password, string lattude, string longtude)
        {
            string pathLoc = String.Format(@"{0}\user.xml", folderLoc);
            XDocument doc = XDocument.Parse(System.IO.File.ReadAllText(pathLoc));
            doc.XPathSelectElement("//PtcUsername").Value = username;
            doc.XPathSelectElement("//PtcPassword").Value = password;
            doc.XPathSelectElement("//DefaultLatitude").Value = lattude;
            doc.XPathSelectElement("//DefaultLongitude").Value = longtude;
            doc.Save(pathLoc);
        }
    }
}