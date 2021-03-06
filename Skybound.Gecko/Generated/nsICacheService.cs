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
// Generated by IDLImporter from file nsICacheService.idl
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
	
	
	/// <summary>nsICacheService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("14dbe1e9-f3bc-45af-92f4-2c574fcd4e39")]
	public interface nsICacheService
	{
		
		/// <summary>
        /// Create a cache session
        ///
        /// A cache session represents a client's access into the cache.  The cache
        /// session is not "owned" by the cache service.  Hence, it is possible to
        /// create duplicate cache sessions.  Entries created by a cache session
        /// are invisible to other cache sessions, unless the cache sessions are
        /// equivalent.
        ///
        /// @param clientID - Specifies the name of the client using the cache.
        /// @param storagePolicy - Limits the storage policy for all entries
        /// accessed via the returned session.  As a result, devices excluded
        /// by the storage policy will not be searched when opening entries
        /// from the returned session.
        /// @param streamBased - Indicates whether or not the data being cached
        /// can be represented as a stream.  The storagePolicy must be
        /// consistent with the value of this field.  For example, a non-stream-
        /// based cache entry can only have a storage policy of STORE_IN_MEMORY.
        /// @return new cache session.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheSession CreateSession([MarshalAs(UnmanagedType.LPStr)] string clientID, System.IntPtr storagePolicy, [MarshalAs(UnmanagedType.Bool)] bool streamBased);
		
		/// <summary>
        /// Visit entries stored in the cache.  Used to implement about:cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitEntries([MarshalAs(UnmanagedType.Interface)] nsICacheVisitor visitor);
		
		/// <summary>
        /// Evicts all entries in all devices implied by the storage policy.
        ///
        /// @note This function may evict some items but will throw if it fails to evict
        /// everything.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvictEntries(System.IntPtr storagePolicy);
		
		/// <summary>
        /// Event target which is used for I/O operations
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEventTarget GetCacheIOTargetAttribute();
	}
}
