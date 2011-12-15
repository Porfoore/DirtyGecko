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
// Generated by IDLImporter from file nsIWebContentConverterRegistrar.idl
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
	
	
	/// <summary>nsIWebContentHandlerInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eb361098-5158-4b21-8f98-50b445f1f0b2")]
	public interface nsIWebContentHandlerInfo : nsIHandlerApp
	{
		
		/// <summary>
        /// Human readable name for the handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Human readable name for the handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>
        /// Detailed description for this handler. Suitable for
        /// a tooltip or short informative sentence.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>
        /// Detailed description for this handler. Suitable for
        /// a tooltip or short informative sentence.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDetailedDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDetailedDescription);
		
		/// <summary>
        /// Whether or not the given handler app is logically equivalent to the
        /// invokant (i.e. they represent the same app).
        ///
        /// Two apps are the same if they are both either local or web handlers
        /// and their executables/URI templates and command line parameters are
        /// the same.
        ///
        /// @param aHandlerApp the handler app to compare to the invokant
        ///
        /// @returns true if the two are logically equivalent, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIHandlerApp aHandlerApp);
		
		/// <summary>
        /// Launches the application with the specified URI.
        ///
        /// @param aURI
        /// The URI to launch this application with
        ///
        /// @param aWindowContext
        ///
        /// Currently only relevant to web-handler apps.  If given, this
        /// represents the docshell to load the handler in and is passed
        /// through to nsIURILoader.openURI.  If this parameter is null or
        /// not present, the web handler app implementation will attempt to
        /// find/create a place to load the handler and do so.  As of this
        /// writing, it tries to load the web handler in a new window using
        /// nsIBrowserDOMWindow.openURI.  In the future, it may attempt to
        /// have a more comprehensive strategy which could include handing
        /// off to the system default browser (bug 394479).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LaunchWithURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>
        /// The content type handled by the handler
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		/// <summary>
        /// The uri of the handler, with an embedded %s where the URI of the loaded
        /// document will be encoded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUriAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUri);
		
		/// <summary>
        /// Gets the service URL Spec, with the loading document URI encoded in it.
        /// @param   uri
        /// The URI of the document being loaded
        /// @returns The URI of the service with the loading document URI encoded in
        /// it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHandlerURI([MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
	}
	
	/// <summary>nsIWebContentConverterService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("de7cc06e-e778-45cb-b7db-7a114e1e75b1")]
	public interface nsIWebContentConverterService : nsIWebContentHandlerRegistrar
	{
		
		/// <summary>
        /// See documentation in nsIDOMClientInformation.idl
        /// The additional contentWindow param for both methods represents the dom
        /// content window from which the method has been called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RegisterContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow contentWindow);
		
		/// <summary>Member RegisterProtocolHandler </summary>
		/// <param name='protocol'> </param>
		/// <param name='uri'> </param>
		/// <param name='title'> </param>
		/// <param name='contentWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RegisterProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow contentWindow);
		
		/// <summary>
        /// Specifies the handler to be used to automatically handle all links of a
        /// certain content type from now on.
        /// @param   contentType
        /// The content type to automatically load with the specified handler
        /// @param   handler
        /// A web service handler. If this is null, no automatic action is
        /// performed and the user must choose.
        /// @throws  NS_ERROR_NOT_AVAILABLE if the service refered to by |handler| is
        /// not already registered.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAutoHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType, [MarshalAs(UnmanagedType.Interface)] nsIWebContentHandlerInfo handler);
		
		/// <summary>
        /// Gets the auto handler specified for a particular content type
        /// @param   contentType
        /// The content type to look up an auto handler for.
        /// @returns The web service handler that will automatically handle all
        /// documents of the specified type. null if there is no automatic
        /// handler. (Handlers may be registered, just none of them specified
        /// as "automatic").
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebContentHandlerInfo GetAutoHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
		
		/// <summary>
        /// Gets a web handler for the specified service URI
        /// @param   contentType
        /// The content type of the service being located
        /// @param   uri
        /// The service URI of the handler to locate.
        /// @returns A web service handler that uses the specified uri.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebContentHandlerInfo GetWebContentHandlerByURI([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>
        /// Loads the preferred handler when content of a registered type is about
        /// to be loaded.
        /// @param   request
        /// The nsIRequest for the load of the content
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadPreferredHandler([MarshalAs(UnmanagedType.Interface)] nsIRequest request);
		
		/// <summary>
        /// Removes a registered protocol handler
        /// @param   protocol
        /// The protocol scheme to remove a service handler for
        /// @param   uri
        /// The uri of the service handler to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>
        /// Removes a registered content handler
        /// @param   contentType
        /// The content type to remove a service handler for
        /// @param   uri
        /// The uri of the service handler to remove
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri);
		
		/// <summary>
        /// Gets the list of content handlers for a particular type.
        /// @param   contentType
        /// The content type to get handlers for
        /// @returns An array of nsIWebContentHandlerInfo objects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentHandlers([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref nsIWebContentHandlerInfo[] handlers);
		
		/// <summary>
        /// Resets the list of available content handlers to the default set from
        /// the distribution.
        /// @param   contentType
        /// The content type to reset handlers for
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetHandlersForType([MarshalAs(UnmanagedType.LPStruct)] nsAString contentType);
	}
}