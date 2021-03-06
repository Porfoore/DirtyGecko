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
// Generated by IDLImporter from file nsIWeakReference.idl
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
    /// An instance of |nsIWeakReference| is a proxy object that cooperates with
    /// its referent to give clients a non-owning, non-dangling reference.  Clients
    /// own the proxy, and should generally manage it with an |nsCOMPtr| (see the
    /// type |nsWeakPtr| for a |typedef| name that stands out) as they would any
    /// other XPCOM object.  The |QueryReferent| member function provides a
    /// (hopefully short-lived) owning reference on demand, through which clients
    /// can get useful access to the referent, while it still exists.
    ///
    /// @version 1.0
    /// @see nsISupportsWeakReference
    /// @see nsWeakReference
    /// @see nsWeakPtr
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9188bc85-f92e-11d2-81ef-0060083a0bcf")]
	public interface nsIWeakReference
	{
		
		/// <summary>
        /// |QueryReferent| queries the referent, if it exists, and like |QueryInterface|, produces
        /// an owning reference to the desired interface.  It is designed to look and act exactly
        /// like (a proxied) |QueryInterface|.  Don't hold on to the produced interface permanently;
        /// that would defeat the purpose of using a non-owning |nsIWeakReference| in the first place.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr QueryReferent(ref System.Guid uuid);
	}
	
	/// <summary>
    /// |nsISupportsWeakReference| is a factory interface which produces appropriate
    /// instances of |nsIWeakReference|.  Weak references in this scheme can only be
    /// produced for objects that implement this interface.
    ///
    /// @version 1.0
    /// @see nsIWeakReference
    /// @see nsSupportsWeakReference
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9188bc86-f92e-11d2-81ef-0060083a0bcf")]
	public interface nsISupportsWeakReference
	{
		
		/// <summary>
        /// |GetWeakReference| produces an appropriate instance of |nsIWeakReference|.
        /// As with all good XPCOM `getters', you own the resulting interface and should
        /// manage it with an |nsCOMPtr|.
        ///
        /// @see nsIWeakReference
        /// @see nsWeakPtr
        /// @see nsCOMPtr
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWeakReference GetWeakReference();
	}
}
