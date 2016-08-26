using System.Xml;
using WhetStone.Looping;

namespace XMLStone
{
    public static class selectNodes
    {
        public static XmlNodeList SelectNodes(this XmlNode @this, string query, params string[] namespaces)
        {
            XmlNamespaceManager xnm = new XmlNamespaceManager(@this.OwnerDocument.NameTable);
            foreach (var ns in namespaces.Chunk(2))
            {
                xnm.AddNamespace(ns[0], ns[1]);
            }
            return @this.SelectNodes(query, xnm);
        }
    }
}
