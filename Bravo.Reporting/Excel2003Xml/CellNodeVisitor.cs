﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Diagnostics;

namespace Bravo.Reporting.Excel2003Xml
{
    internal class CellNodeVisitor : INodeVisitor
    {
        #region INodeVisitor 成员

        public void ProcessNode(XmlNode node)
        {
            Debug.Assert(node.NodeType == XmlNodeType.Element);
            Debug.Assert(node.Name == "Cell");

            var cell = (XmlElement)node;

            if (cell.ChildNodes.Count == 1 &&
                cell.FirstChild.Name == "Data" &&
                cell.FirstChild.InnerText == "#VALUE!")
            {
                cell.FirstChild.InnerText = "";
            }

        }

        #endregion
    }
}
