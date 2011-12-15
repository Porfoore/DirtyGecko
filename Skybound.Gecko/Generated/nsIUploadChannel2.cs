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
// Generated by IDLImporter from file nsIUploadChannel2.idl
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
	
	
	/// <summary>nsIUploadChannel2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AD9D3F1C-A8DE-4d0b-9714-1B922297AD65")]
	public interface nsIUploadChannel2
	{
		
		/// <summary>
        /// Sets a stream to be uploaded by this channel with the specified
        /// Content-Type and Content-Length header values.
        ///
        /// Most implementations of this interface require that the stream:
        /// (1) implement threadsafe addRef and release
        /// (2) implement nsIInputStream::readSegments
        /// (3) implement nsISeekableStream::seek
        ///
        /// @param aStream
        /// The stream to be uploaded by this channel.
        /// @param aContentType
        /// This value will replace any existing Content-Type
        /// header on the HTTP request, regardless of whether
        /// or not its empty.
        /// @param aContentLength
        /// A value of -1 indicates that the length of the stream should be
        /// determined by calling the stream's |available| method.
        /// @param aMethod
        /// The HTTP request method to set on the stream.
        /// @param aStreamHasHeaders
        /// True if the stream already contains headers for the HTTP request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExplicitSetUploadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStruct)] nsACString aContentType, int aContentLength, [MarshalAs(UnmanagedType.LPStruct)] nsACString aMethod, [MarshalAs(UnmanagedType.Bool)] bool aStreamHasHeaders);
		
		/// <summary>
        /// Value of aStreamHasHeaders from the last successful call to
        /// explicitSetUploadStream.  TRUE indicates the attached upload stream
        /// contians request headers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUploadStreamHasHeadersAttribute();
	}
}
