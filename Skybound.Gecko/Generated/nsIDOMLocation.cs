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
// Generated by IDLImporter from file nsIDOMLocation.idl
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
	
	
	/// <summary>nsIDOMLocation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf906d-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMLocation
	{
		
		/// <summary>
        /// These properties refer to the current location of the document.
        /// This will correspond to the URI shown in the location bar, which
        /// can be different from the documentURI of the document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHash);
		
		/// <summary>
        /// These properties refer to the current location of the document.
        /// This will correspond to the URI shown in the location bar, which
        /// can be different from the documentURI of the document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHash);
		
		/// <summary>Member GetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost);
		
		/// <summary>Member SetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHost);
		
		/// <summary>Member GetHostnameAttribute </summary>
		/// <param name='aHostname'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		/// <summary>Member SetHostnameAttribute </summary>
		/// <param name='aHostname'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHostname);
		
		/// <summary>Member GetHrefAttribute </summary>
		/// <param name='aHref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		/// <summary>Member SetHrefAttribute </summary>
		/// <param name='aHref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		/// <summary>Member GetPathnameAttribute </summary>
		/// <param name='aPathname'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPathname);
		
		/// <summary>Member SetPathnameAttribute </summary>
		/// <param name='aPathname'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPathnameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPathname);
		
		/// <summary>Member GetPortAttribute </summary>
		/// <param name='aPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPort);
		
		/// <summary>Member SetPortAttribute </summary>
		/// <param name='aPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPort);
		
		/// <summary>Member GetProtocolAttribute </summary>
		/// <param name='aProtocol'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProtocol);
		
		/// <summary>Member SetProtocolAttribute </summary>
		/// <param name='aProtocol'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProtocolAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProtocol);
		
		/// <summary>Member GetSearchAttribute </summary>
		/// <param name='aSearch'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearch);
		
		/// <summary>Member SetSearchAttribute </summary>
		/// <param name='aSearch'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearch);
		
		/// <summary>Member Reload </summary>
		/// <param name='forceget'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reload([MarshalAs(UnmanagedType.Bool)] bool forceget);
		
		/// <summary>Member Replace </summary>
		/// <param name='url'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Replace([MarshalAs(UnmanagedType.LPStruct)] nsAString url);
		
		/// <summary>Member Assign </summary>
		/// <param name='url'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Assign([MarshalAs(UnmanagedType.LPStruct)] nsAString url);
		
		/// <summary>Member ToString </summary>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
	}
}
