// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class RootWithRefAndMeta : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "RootWithRefAndMeta");
            if (Optional.IsDefined(RefToModel))
            {
                writer.WriteObjectValue(RefToModel, "XMLComplexTypeWithMeta");
            }
            if (Optional.IsDefined(Something))
            {
                writer.WriteStartElement("Something");
                writer.WriteValue(Something);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static RootWithRefAndMeta DeserializeRootWithRefAndMeta(XElement element)
        {
            ComplexTypeWithMeta refToModel = default;
            string something = default;
            if (element.Element("XMLComplexTypeWithMeta") is XElement xmlComplexTypeWithMetaElement)
            {
                refToModel = ComplexTypeWithMeta.DeserializeComplexTypeWithMeta(xmlComplexTypeWithMetaElement);
            }
            if (element.Element("Something") is XElement somethingElement)
            {
                something = (string)somethingElement;
            }
            return new RootWithRefAndMeta(refToModel, something);
        }
    }
}
