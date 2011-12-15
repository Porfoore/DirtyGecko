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
// Generated by IDLImporter from file nsIUTF8ConverterService.idl
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
	
	
	/// <summary>nsIUTF8ConverterService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("249f52a3-2599-4b00-ba40-0481364831a2")]
	public interface nsIUTF8ConverterService
	{
		
		/// <summary>
        /// Ensure that |aString| is encoded in UTF-8.  If not,
        /// convert to UTF-8 assuming it's encoded in |aCharset|
        /// and return the converted string in UTF-8.
        ///
        /// @param aString a string to  ensure its UTF8ness
        /// @param aCharset the charset to convert from if |aString| is not in UTF-8
        /// @param aSkipCheck determines whether or not to skip 'ASCIIness' and
        /// 'UTF8ness' check. Set this to PR_TRUE only if you suspect that
        /// aString can be mistaken for ASCII / UTF-8 but is actually NOT
        /// in ASCII / UTF-8 so that aString has to go through the conversion.
        /// skipping ASCIIness/UTF8ness check.
        /// The most common case is the input is in 7bit non-ASCII charsets
        /// like ISO-2022-JP, HZ or UTF-7 (in its original form or
        /// a modified form used in IMAP folder names).
        /// @return the converted string in UTF-8.
        /// @throws NS_ERROR_UCONV_NOCONV when there is no decoder for aCharset
        /// or error code of nsIUnicodeDecoder in case of conversion failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertStringToUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACString aString, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.Bool)] bool aSkipCheck, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        /// Ensure that |aSpec| (after URL-unescaping it) is encoded in UTF-8.
        /// If not,  convert it to UTF-8, assuming it's encoded in |aCharset|,
        /// and return the result.
        ///
        /// <p>Make sure that all characters outside US-ASCII in your input spec
        /// are url-escaped if  your spec is not in UTF-8 (before url-escaping)
        /// because the presence of non-ASCII characters is <strong>blindly</strong>
        /// regarded as an indication that your input spec is in unescaped UTF-8
        /// and it will be returned without further processing. No valid spec
        /// going around in Mozilla code would break this assumption.
        ///
        /// <p>XXX The above may change in the future depending on the usage pattern.
        ///
        /// @param aSpec an url-escaped URI spec to  ensure its UTF8ness
        /// @param aCharset the charset to convert from if |aSpec| is not in UTF-8
        /// @return the converted spec in UTF-8.
        /// @throws NS_ERROR_UCONV_NOCONV when there is no decoder for aCharset
        /// or error code of nsIUnicodeDecoder in case of conversion failure
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertURISpecToUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACString aSpec, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
	}
}
