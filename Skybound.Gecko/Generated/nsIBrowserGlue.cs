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
// Generated by IDLImporter from file nsIBrowserGlue.idl
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
    /// nsIBrowserGlue is a dirty and rather fluid interface to host shared utility
    /// methods used by browser UI code, but which are not local to a browser window.
    /// The component implementing this interface is meant to be a singleton
    /// (service) and should progressively replace some of the shared "glue" code
    /// scattered in browser/base/content (e.g. bits of utilOverlay.js,
    /// contentAreaUtils.js, globalOverlay.js, browser.js), avoiding dynamic
    /// inclusion and initialization of a ton of JS code for *each* window.
    /// Dued to its nature and origin, this interface won't probably be the most
    /// elegant or stable in the mozilla codebase, but its aim is rather pragmatic:
    /// 1) reducing the performance overhead which affects browser window load;
    /// 2) allow global hooks (e.g. startup and shutdown observers) which survive
    /// browser windows to accomplish browser-related activities, such as shutdown
    /// sanitization (see bug #284086)
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("781df699-17dc-4237-b3d7-876ddb7085e3")]
	public interface nsIBrowserGlue
	{
		
		/// <summary>
        /// Deletes privacy sensitive data according to user preferences
        ///
        /// @param aParentWindow an optionally null window which is the parent of the
        /// sanitization dialog
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Sanitize([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParentWindow);
		
		/// <summary>
        /// Add Smart Bookmarks special queries to bookmarks menu and toolbar folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnsurePlacesDefaultQueriesInitialized();
		
		/// <summary>
        /// Gets the most recent window that's a browser (but not a popup)
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetMostRecentBrowserWindow();
	}
}
