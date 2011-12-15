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
// Generated by IDLImporter from file nsIDOMCounter.idl
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
	
	
	/// <summary>nsIDOMCounter </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31adb439-0055-402d-9b1d-d5ca94f3f55b")]
	public interface nsIDOMCounter
	{
		
		/// <summary>Member GetIdentifierAttribute </summary>
		/// <param name='aIdentifier'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdentifierAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aIdentifier);
		
		/// <summary>Member GetListStyleAttribute </summary>
		/// <param name='aListStyle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListStyleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aListStyle);
		
		/// <summary>Member GetSeparatorAttribute </summary>
		/// <param name='aSeparator'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSeparatorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSeparator);
	}
}
