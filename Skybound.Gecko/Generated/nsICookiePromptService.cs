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
// Generated by IDLImporter from file nsICookiePromptService.idl
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
    /// An interface to open a dialog to ask to permission to accept the cookie.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("72f8bb14-2810-4f38-8d0d-290c5401f54e")]
	public interface nsICookiePromptService
	{
		
		/// <summary>
        ///Open a dialog that asks for permission to accept a cookie
        ///
        /// @param parent
        /// @param cookie
        /// @param hostname          the host that wants to set the cookie,
        /// not the domain: part of the cookie
        /// @param cookiesFromHost   the number of cookies there are already for this host
        /// @param changingCookie    are we changing this cookie?
        /// @param rememberDecision  should we set the matching permission for this host?
        /// @returns                 0 == deny cookie
        /// 1 == accept cookie
        /// 2 == accept cookie for current session
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CookieDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsICookie cookie, [MarshalAs(UnmanagedType.LPStruct)] nsACString hostname, int cookiesFromHost, [MarshalAs(UnmanagedType.Bool)] bool changingCookie, [MarshalAs(UnmanagedType.Bool)] ref bool rememberDecision);
	}
}
