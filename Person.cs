using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
public class Person
{
    [XmlAttribute("Id")]
    public int PersonId { get; set; }
    [XmlElement("Imie")]
    public string FirstName { get; set; }
    [XmlElement("Nazwisko")]
    public string LastName { get; set; }
    [XmlElement("Wiek")]
    public int Age { get; set; }

    public Person()
    {
    }

    public Person(int nPersonId, string sFirstName, string sLastName, int nAge)
    {
        PersonId = nPersonId;
        FirstName = sFirstName;
        LastName = sLastName;
        Age = nAge;
    }
}







