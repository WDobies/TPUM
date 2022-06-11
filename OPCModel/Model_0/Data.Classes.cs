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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Data
{
    #region ProductState Class
    #if (!OPCUA_EXCLUDE_ProductState)
    /// <summary>
    /// Stores an instance of the Product ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProductState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProductState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Data.ObjectTypes.Product, Data.Namespaces.Data, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABEAAABodHRwOi9UUFVNL01vZGVsL/////8EYIACAQAAAAEADwAAAFByb2R1Y3RJbnN0YW5jZQEB" +
           "AQABAQEAAQAAAP////8FAAAAFWCJCgIAAAABAAQAAABOYW1lAQECAAAuAEQCAAAAAAz/////AQH/////" +
           "AAAAABVgiQoCAAAAAQACAAAASUQBAQMAAC4ARAMAAAAADv////8BAf////8AAAAAFWCJCgIAAAABAAUA" +
           "AABDb3VudAEBBAAALgBEBAAAAAAb/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAERlc2NyaXB0aW9u" +
           "AQEFAAAuAEQFAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAUHJpY2UBAQYAAC4ARAYAAAAA" +
           "Cv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public PropertyState<Guid> ID
        {
            get
            {
                return m_iD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iD = value;
            }
        }

        /// <remarks />
        public PropertyState Count
        {
            get
            {
                return m_count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_count = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Description
        {
            get
            {
                return m_description;
            }

            set
            {
                if (!Object.ReferenceEquals(m_description, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_description = value;
            }
        }

        /// <remarks />
        public PropertyState<float> Price
        {
            get
            {
                return m_price;
            }

            set
            {
                if (!Object.ReferenceEquals(m_price, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_price = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_iD != null)
            {
                children.Add(m_iD);
            }

            if (m_count != null)
            {
                children.Add(m_count);
            }

            if (m_description != null)
            {
                children.Add(m_description);
            }

            if (m_price != null)
            {
                children.Add(m_price);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Data.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Data.BrowseNames.ID:
                {
                    if (createOrReplace)
                    {
                        if (ID == null)
                        {
                            if (replacement == null)
                            {
                                ID = new PropertyState<Guid>(this);
                            }
                            else
                            {
                                ID = (PropertyState<Guid>)replacement;
                            }
                        }
                    }

                    instance = ID;
                    break;
                }

                case Data.BrowseNames.Count:
                {
                    if (createOrReplace)
                    {
                        if (Count == null)
                        {
                            if (replacement == null)
                            {
                                Count = new PropertyState(this);
                            }
                            else
                            {
                                Count = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = Count;
                    break;
                }

                case Data.BrowseNames.Description:
                {
                    if (createOrReplace)
                    {
                        if (Description == null)
                        {
                            if (replacement == null)
                            {
                                Description = new PropertyState<string>(this);
                            }
                            else
                            {
                                Description = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Description;
                    break;
                }

                case Data.BrowseNames.Price:
                {
                    if (createOrReplace)
                    {
                        if (Price == null)
                        {
                            if (replacement == null)
                            {
                                Price = new PropertyState<float>(this);
                            }
                            else
                            {
                                Price = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = Price;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_name;
        private PropertyState<Guid> m_iD;
        private PropertyState m_count;
        private PropertyState<string> m_description;
        private PropertyState<float> m_price;
        #endregion
    }
    #endif
    #endregion
}