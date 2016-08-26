using System.Xml;

namespace XMLStone
{
    public static class toXmlDoc
    {
        public static XmlDocument ToXmlDoc(string innertext)
        {
            XmlDocument ret = new XmlDocument();
            ret.LoadXml(innertext);
            return ret;
        }
    }
}
