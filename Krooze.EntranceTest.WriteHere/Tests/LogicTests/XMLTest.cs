using Krooze.EntranceTest.WriteHere.Structure.Model;
using System;
using System.IO;
using System.Xml;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class XMLTest
    {
        public CruiseDTO TranslateXML()
        {
            CruiseDTO cruiseDTO = new CruiseDTO();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //TODO: Take the Cruises.xml file, on the Resources folder, and translate it to the CruisesDTO object,
            string xmlPath = Path.Combine(baseDirectory, "Resources/Cruises.xml");
            using (var xml = System.Xml.XmlReader.Create(xmlPath))
            {
                var serialise = new System.Xml.Serialization.XmlSerializer(typeof(CruiseDTO));
                cruiseDTO = (CruiseDTO)serialise.Deserialize(xml);
            }
            return cruiseDTO;
        }
    }
}
