using System;
using System.Xml.Serialization;

namespace RRTools
{
    [Serializable, XmlRoot(ElementName = "list", Namespace = "")]
    public class List
    {
        [XmlElement(ElementName = "record", Namespace = "")]
        public Pilot[] Pilots { get; set; }
    }
}
