// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMXMLDocument.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIDOMXMLDocument </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f97b36ff-425f-4c87-b6dc-fcfcfb4d5c77")]
	public interface nsIDOMXMLDocument : nsIDOMDocument
	{
		
		/// <summary>
        /// The nsIDOMNode interface is the primary datatype for the entire
        /// Document Object Model.
        /// It represents a single node in the document tree.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.Bool)] bool deep);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>
        /// Modified in DOM Core
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// nsINode::GetBaseURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBaseURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBaseURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint CompareDocumentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMNode other);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSameNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode other);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsEqualNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode arg);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant SetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, [MarshalAs(UnmanagedType.Interface)] nsIDOMUserDataHandler handler);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAString key);
		
		/// <summary>
        /// The nsIDOMDocument interface represents the entire HTML or XML document.
        /// Conceptually, it is the root of the document tree, and provides the
        /// primary access to the document's data.
        /// Since elements, text nodes, comments, processing instructions, etc.
        /// cannot exist outside the context of a Document, the nsIDOMDocument
        /// interface also contains the factory methods needed to create these
        /// objects.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentType GetDoctypeAttribute();
		
		/// <summary>Member GetImplementationAttribute </summary>
		/// <returns>A nsIDOMDOMImplementation</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMImplementation GetImplementationAttribute();
		
		/// <summary>Member GetDocumentElementAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetDocumentElementAttribute();
		
		/// <summary>Member CreateElement </summary>
		/// <param name='tagName'> </param>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		/// <summary>Member CreateDocumentFragment </summary>
		/// <returns>A nsIDOMDocumentFragment</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentFragment CreateDocumentFragment();
		
		/// <summary>Member CreateTextNode </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMText</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMText CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateComment </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMComment</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMComment CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateCDATASection </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMCDATASection</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCDATASection CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateProcessingInstruction </summary>
		/// <param name='target'> </param>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMProcessingInstruction</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMProcessingInstruction CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target, [MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member GetElementsByTagName </summary>
		/// <param name='tagname'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ImportNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode importedNode, [MarshalAs(UnmanagedType.Bool)] bool deep);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetInputEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aInputEncoding);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetXmlEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aXmlEncoding);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetXmlStandaloneAttribute();
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetXmlStandaloneAttribute([MarshalAs(UnmanagedType.Bool)] bool aXmlStandalone);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetXmlVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aXmlVersion);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetXmlVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aXmlVersion);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDocumentURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDocumentURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDocumentURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDocumentURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AdoptNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode source);
		
		/// <summary>
        /// Create a range
        ///
        /// @see http://html5.org/specs/dom-range.html#dom-document-createrange
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMRange CreateRange();
		
		/// <summary>Member CreateNodeIterator </summary>
		/// <param name='root'> </param>
		/// <param name='whatToShow'> </param>
		/// <param name='filter'> </param>
		/// <param name='entityReferenceExpansion'> </param>
		/// <returns>A nsIDOMNodeIterator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeIterator CreateNodeIterator([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, [MarshalAs(UnmanagedType.Bool)] bool entityReferenceExpansion);
		
		/// <summary>Member CreateTreeWalker </summary>
		/// <param name='root'> </param>
		/// <param name='whatToShow'> </param>
		/// <param name='filter'> </param>
		/// <param name='entityReferenceExpansion'> </param>
		/// <returns>A nsIDOMTreeWalker</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMTreeWalker CreateTreeWalker([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, [MarshalAs(UnmanagedType.Bool)] bool entityReferenceExpansion);
		
		/// <summary>Member CreateEvent </summary>
		/// <param name='eventType'> </param>
		/// <returns>A nsIDOMEvent</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEvent CreateEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString eventType);
		
		/// <summary>
        /// The window associated with this document.
        ///
        /// @see <http://www.whatwg.org/html/#dom-document-defaultview>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetDefaultViewAttribute();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-characterset>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharacterSet);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-dir>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-dir>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-location>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMLocation GetLocationAttribute();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#document.title>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#document.title>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-readystate>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetReadyStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aReadyState);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-lastmodified>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLastModifiedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastModified);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-referrer>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetReferrerAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-hasfocus>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasFocus();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-activeelement>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetActiveElementAttribute();
		
		/// <summary>
        /// Retrieve elements matching all classes listed in a
        /// space-separated string.
        ///
        /// @see <http://www.whatwg.org/html/#dom-document-getelementsbyclassname>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		/// <summary>
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-stylesheets>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMStyleSheetList GetStyleSheetsAttribute();
		
		/// <summary>
        /// This attribute must return the preferred style sheet set as set by the
        /// author. It is determined from the order of style sheet declarations and
        /// the Default-Style HTTP headers, as eventually defined elsewhere in the Web
        /// Apps 1.0 specification. If there is no preferred style sheet set, this
        /// attribute must return the empty string. The case of this attribute must
        /// exactly match the case given by the author where the preferred style sheet
        /// is specified or implied. This attribute must never return null.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-preferredStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPreferredStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPreferredStyleSheetSet);
		
		/// <summary>
        /// This attribute indicates which style sheet set is in use. This attribute
        /// is live; changing the disabled attribute on style sheets directly will
        /// change the value of this attribute.
        ///
        /// If all the sheets that are enabled and have a title have the same title
        /// (by case-sensitive comparisons) then the value of this attribute must be
        /// exactly equal to the title of the first enabled style sheet with a title
        /// in the styleSheets list. Otherwise, if style sheets from different sets
        /// are enabled, then the return value must be null (there is no way to
        /// determine what the currently selected style sheet set is in those
        /// conditions). Otherwise, either all style sheets that have a title are
        /// disabled, or there are no alternate style sheets, and
        /// selectedStyleSheetSet must return the empty string.
        ///
        /// Setting this attribute to the null value must have no effect.
        ///
        /// Setting this attribute to a non-null value must call
        /// enableStyleSheetsForSet() with that value as the function's argument, and
        /// set lastStyleSheetSet to that value.
        ///
        /// From the DOM's perspective, all views have the same
        /// selectedStyleSheetSet. If a UA supports multiple views with different
        /// selected alternate style sheets, then this attribute (and the StyleSheet
        /// interface's disabled attribute) must return and set the value for the
        /// default view.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSelectedStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectedStyleSheetSet);
		
		/// <summary>
        /// This attribute indicates which style sheet set is in use. This attribute
        /// is live; changing the disabled attribute on style sheets directly will
        /// change the value of this attribute.
        ///
        /// If all the sheets that are enabled and have a title have the same title
        /// (by case-sensitive comparisons) then the value of this attribute must be
        /// exactly equal to the title of the first enabled style sheet with a title
        /// in the styleSheets list. Otherwise, if style sheets from different sets
        /// are enabled, then the return value must be null (there is no way to
        /// determine what the currently selected style sheet set is in those
        /// conditions). Otherwise, either all style sheets that have a title are
        /// disabled, or there are no alternate style sheets, and
        /// selectedStyleSheetSet must return the empty string.
        ///
        /// Setting this attribute to the null value must have no effect.
        ///
        /// Setting this attribute to a non-null value must call
        /// enableStyleSheetsForSet() with that value as the function's argument, and
        /// set lastStyleSheetSet to that value.
        ///
        /// From the DOM's perspective, all views have the same
        /// selectedStyleSheetSet. If a UA supports multiple views with different
        /// selected alternate style sheets, then this attribute (and the StyleSheet
        /// interface's disabled attribute) must return and set the value for the
        /// default view.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSelectedStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectedStyleSheetSet);
		
		/// <summary>
        /// This property must initially have the value null. Its value changes when
        /// the selectedStyleSheetSet attribute is set.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-lastStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLastStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastStyleSheetSet);
		
		/// <summary>
        /// This must return the live list of the currently available style sheet
        /// sets. This list is constructed by enumerating all the style sheets for
        /// this document available to the implementation, in the order they are
        /// listed in the styleSheets attribute, adding the title of each style sheet
        /// with a title to the list, avoiding duplicates by dropping titles that
        /// match (case-sensitively) titles that have already been added to the
        /// list.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-styleSheetSets>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetStyleSheetSetsAttribute();
		
		/// <summary>
        /// Calling this method must change the disabled attribute on each StyleSheet
        /// object with a title attribute with a length greater than 0 in the
        /// styleSheets attribute, so that all those whose title matches the name
        /// argument are enabled, and all others are disabled. Title matches must be
        /// case-sensitive. Calling this method with the empty string disables all
        /// alternate and preferred style sheets (but does not change the state of
        /// persistent style sheets, that is those with no title attribute).
        ///
        /// Calling this method with a null value must have no effect.
        ///
        /// Style sheets that do not have a title are never affected by this
        /// method. This method does not change the values of the lastStyleSheetSet or
        /// preferredStyleSheetSet attributes.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-enableStyleSheetsForSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void EnableStyleSheetsForSet([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Returns the element from the caller's document at the given point,
        /// relative to the upper-left-most point in the (possibly scrolled)
        /// window or frame.
        ///
        /// If the element at the given point belongs to another document (such as
        /// an iframe's subdocument), the element in the calling document's DOM
        /// (e.g. the iframe) is returned. If the element at the given point is
        /// anonymous or XBL generated content, such as a textbox's scrollbars, then
        /// the first non-anonymous parent element (that is, the textbox) is returned.
        ///
        /// This method returns null if either coordinate is negative, or if the
        /// specified point lies outside the visible bounds of the document.
        ///
        /// Callers from XUL documents should wait until the onload event has fired
        /// before calling this method.
        ///
        /// @see <http://dev.w3.org/csswg/cssom-view/#dom-document-elementfrompoint>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement ElementFromPoint(float x, float y);
		
		/// <summary>
        /// @see <https://developer.mozilla.org/en/DOM/document.contentType>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>
        /// True if this document is synthetic : stand alone image, video, audio file,
        /// etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozSyntheticDocumentAttribute();
		
		/// <summary>
        /// Returns the script element whose script is currently being processed.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.currentScript>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetCurrentScriptAttribute();
		
		/// <summary>
        /// Release the current mouse capture if it is on an element within this
        /// document.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.releaseCapture>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ReleaseCapture();
		
		/// <summary>
        /// Use the given DOM element as the source image of target |-moz-element()|.
        ///
        /// This function introduces a new special ID (called "image element ID"),
        /// which is only used by |-moz-element()|, and associates it with the given
        /// DOM element.  Image elements ID's have the higher precedence than general
        /// HTML id's, so if |document.mozSetImageElement(<id>, <element>)| is called,
        /// |-moz-element(#<id>)| uses |<element>| as the source image even if there
        /// is another element with id attribute = |<id>|.  To unregister an image
        /// element ID |<id>|, call |document.mozSetImageElement(<id>, null)|.
        ///
        /// Example:
        /// <script>
        /// canvas = document.createElement("canvas");
        /// canvas.setAttribute("width", 100);
        /// canvas.setAttribute("height", 100);
        /// // draw to canvas
        /// document.mozSetImageElement("canvasbg", canvas);
        /// </script>
        /// <div style="background-image: -moz-element(#canvasbg);"></div>
        ///
        /// @param aImageElementId an image element ID to associate with
        /// |aImageElement|
        /// @param aImageElement a DOM element to be used as the source image of
        /// |-moz-element(#aImageElementId)|. If this is null, the function will
        /// unregister the image element ID |aImageElementId|.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.mozSetImageElement>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozSetImageElement([MarshalAs(UnmanagedType.LPStruct)] nsAString aImageElementId, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aImageElement);
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAsyncAttribute();
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsyncAttribute([MarshalAs(UnmanagedType.Bool)] bool aAsync);
		
		/// <summary>
        /// Load an XML document.
        ///
        /// @param  url URL to an XML document.
        /// @return     True if load successfull.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Load([MarshalAs(UnmanagedType.LPStruct)] nsAString url);
	}
}