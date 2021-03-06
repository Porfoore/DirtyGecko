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
// Generated by IDLImporter from file nsICacheSession.idl
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
	
	
	/// <summary>nsICacheSession </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ae9e84b5-3e2d-457e-8fcd-5bbd2a8b832e")]
	public interface nsICacheSession
	{
		
		/// <summary>
        /// Expired entries will be doomed or evicted if this attribute is set to
        /// true.  If false, expired entries will be returned (useful for offline-
        /// mode and clients, such as HTTP, that can update the valid lifetime of
        /// cached content).  This attribute defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoomEntriesIfExpiredAttribute();
		
		/// <summary>
        /// Expired entries will be doomed or evicted if this attribute is set to
        /// true.  If false, expired entries will be returned (useful for offline-
        /// mode and clients, such as HTTP, that can update the valid lifetime of
        /// cached content).  This attribute defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDoomEntriesIfExpiredAttribute([MarshalAs(UnmanagedType.Bool)] bool aDoomEntriesIfExpired);
		
		/// <summary>
        /// Synchronous cache access.  This returns a unique descriptor each
        /// time it is called, even if the same key is specified.  When
        /// called by multiple threads for write access, only one writable
        /// descriptor will be granted.  If 'blockingMode' is set to false, it will
        /// return NS_ERROR_CACHE_WAIT_FOR_VALIDATION rather than block when another
        /// descriptor has been given WRITE access but hasn't validated the entry yet.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheEntryDescriptor OpenCacheEntry([MarshalAs(UnmanagedType.LPStruct)] nsACString key, System.IntPtr accessRequested, [MarshalAs(UnmanagedType.Bool)] bool blockingMode);
		
		/// <summary>
        /// Asynchronous cache access. Does not block the calling thread.
        /// Instead, the listener will be notified when the descriptor is
        /// available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncOpenCacheEntry([MarshalAs(UnmanagedType.LPStruct)] nsACString key, System.IntPtr accessRequested, [MarshalAs(UnmanagedType.Interface)] nsICacheListener listener);
		
		/// <summary>
        /// Evict all entries for this session's clientID according to its storagePolicy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvictEntries();
		
		/// <summary>
        /// Return whether any of the cache devices implied by the session storage policy
        /// are currently enabled for instantiation if they don't already exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsStorageEnabled();
	}
}
