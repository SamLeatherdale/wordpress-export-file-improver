using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WordPress_Duplicate_Resolver
{
	class ItemNode
	{
		public XmlNode titleNode;
		public XmlNode linkNode;
		public XmlNode pubDateNode;
		public XmlNode postDateNode;
		public XmlNode postDateGmtNode;
		public XmlNode attachmentUrlNode;
	}
}
