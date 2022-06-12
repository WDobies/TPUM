/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Data
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the Product DataType.
        /// </summary>
        public const uint Product = 1;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the Product_Name Variable.
        /// </summary>
        public const uint Product_Name = 2;

        /// <summary>
        /// The identifier for the Product_ID Variable.
        /// </summary>
        public const uint Product_ID = 3;

        /// <summary>
        /// The identifier for the Product_Count Variable.
        /// </summary>
        public const uint Product_Count = 4;

        /// <summary>
        /// The identifier for the Product_Description Variable.
        /// </summary>
        public const uint Product_Description = 5;

        /// <summary>
        /// The identifier for the Product_Price Variable.
        /// </summary>
        public const uint Product_Price = 6;

        /// <summary>
        /// The identifier for the Data_BinarySchema Variable.
        /// </summary>
        public const uint Data_BinarySchema = 7;

        /// <summary>
        /// The identifier for the Data_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint Data_BinarySchema_NamespaceUri = 9;

        /// <summary>
        /// The identifier for the Data_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint Data_BinarySchema_Deprecated = 10;

        /// <summary>
        /// The identifier for the Data_XmlSchema Variable.
        /// </summary>
        public const uint Data_XmlSchema = 11;

        /// <summary>
        /// The identifier for the Data_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint Data_XmlSchema_NamespaceUri = 13;

        /// <summary>
        /// The identifier for the Data_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint Data_XmlSchema_Deprecated = 14;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the Product DataType.
        /// </summary>
        public static readonly ExpandedNodeId Product = new ExpandedNodeId(Data.DataTypes.Product, Data.Namespaces.Data);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the Product_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Product_Name = new ExpandedNodeId(Data.Variables.Product_Name, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Product_ID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Product_ID = new ExpandedNodeId(Data.Variables.Product_ID, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Product_Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Product_Count = new ExpandedNodeId(Data.Variables.Product_Count, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Product_Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId Product_Description = new ExpandedNodeId(Data.Variables.Product_Description, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Product_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId Product_Price = new ExpandedNodeId(Data.Variables.Product_Price, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_BinarySchema = new ExpandedNodeId(Data.Variables.Data_BinarySchema, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_BinarySchema_NamespaceUri = new ExpandedNodeId(Data.Variables.Data_BinarySchema_NamespaceUri, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_BinarySchema_Deprecated = new ExpandedNodeId(Data.Variables.Data_BinarySchema_Deprecated, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_XmlSchema = new ExpandedNodeId(Data.Variables.Data_XmlSchema, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_XmlSchema_NamespaceUri = new ExpandedNodeId(Data.Variables.Data_XmlSchema_NamespaceUri, Data.Namespaces.Data);

        /// <summary>
        /// The identifier for the Data_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_XmlSchema_Deprecated = new ExpandedNodeId(Data.Variables.Data_XmlSchema_Deprecated, Data.Namespaces.Data);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Count component.
        /// </summary>
        public const string Count = "Count";

        /// <summary>
        /// The BrowseName for the Data_BinarySchema component.
        /// </summary>
        public const string Data_BinarySchema = "Data";

        /// <summary>
        /// The BrowseName for the Data_XmlSchema component.
        /// </summary>
        public const string Data_XmlSchema = "Data";

        /// <summary>
        /// The BrowseName for the Description component.
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// The BrowseName for the ID component.
        /// </summary>
        public const string ID = "ID";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the Price component.
        /// </summary>
        public const string Price = "Price";

        /// <summary>
        /// The BrowseName for the Product component.
        /// </summary>
        public const string Product = "Product";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Data namespace (.NET code namespace is 'Data').
        /// </summary>
        public const string Data = "http:/TPUM/Model/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}