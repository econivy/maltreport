﻿//作者：李维
//创建时间：2010-09-09
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sandwych.Reporting.OfficeXml
{
	internal sealed class WordMLNamespaceManager : XmlNamespaceManager
	{
		public const string WNamespace = @"http://schemas.microsoft.com/office/word/2003/wordml";
		public const string ONamespace = @"urn:schemas-microsoft-com:office:office";

		public WordMLNamespaceManager (XmlNameTable xnt)
            : base(xnt)
		{
		}

		public void LoadOpenDocumentNamespaces ()
		{
			this.AddNamespace ("w", WNamespace);
			this.AddNamespace ("o", ONamespace);
		}
	}
}
