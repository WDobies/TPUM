using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ServerLogic
{
    public class Serializer
    {
        public Serializer() 
        {
            products = new List<ProductXML>();
        }

        public List<ProductXML> products;

        public string ParseToXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Serializer));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, this);
                string m = textWriter.ToString();
                return m;
            }
        }

        public void DeserializeXML(string message)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Serializer));
            StringReader reader = new StringReader(message);
            Serializer product = (Serializer)deserializer.Deserialize(reader);
            reader.Close();
            foreach (ProductXML p in product.products)
            {
                products.Add(p);
            }
        }
    }
}
