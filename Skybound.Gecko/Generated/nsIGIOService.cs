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
// Generated by IDLImporter from file nsIGIOService.idl
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
	
	
	/// <summary>
    /// 66009894-9877-405b-9321-bf30420e34e6 prev uuid
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ca6bad0c-8a48-48ac-82c7-27bb8f510fbe")]
	public interface nsIGIOMimeApp
	{
		
		/// <summary>
        /// 66009894-9877-405b-9321-bf30420e34e6 prev uuid
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aCommand);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetExpectsURIsAttribute();
		
		/// <summary>
        /// see constants above
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetSupportedURISchemesAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Launch([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String uri);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsDefaultForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String mimeType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsDefaultForFileExtensions([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String extensions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsDefaultForURIScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String uriScheme);
	}
	
	/// <summary>
    /// prev id dea20bf0-4e4d-48c5-b932-dc3e116dc64b
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eda22a30-84e1-4e16-9ca0-cd1553c2b34a")]
	public interface nsIGIOService
	{
		
		/// <summary>
        ///Obtain the MIME type registered for an extension.  The extension
        ///     should not include a leading dot. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeTypeFromExtension([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String extension, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        ///Obtain the preferred application for opening a given URI scheme </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIGIOMimeApp GetAppForURIScheme([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aURIScheme);
		
		/// <summary>
        ///Obtain the preferred application for opening a given MIME type </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIGIOMimeApp GetAppForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String mimeType);
		
		/// <summary>
        ///Obtain the preferred application for opening a given MIME type </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIGIOMimeApp CreateAppFromCommand([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String cmd, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String appName);
		
		/// <summary>
        ///Obtain a description for the given MIME type </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionForMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        ///Open the given URI in the default application </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowURIForInput([MarshalAs(UnmanagedType.LPStruct)] nsACString uri);
	}
}
