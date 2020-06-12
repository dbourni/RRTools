using System;
using System.Xml.Serialization;

namespace RRTools
{
    [Serializable, XmlRoot(ElementName = "record", Namespace = "")]
    public class Pilot
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BibNumber { get; set; }
        public int LicenseNumber { get; set; }
    }
}
