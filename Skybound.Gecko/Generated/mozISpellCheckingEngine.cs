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
// Generated by IDLImporter from file mozISpellCheckingEngine.idl
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
    /// This interface represents a SpellChecker.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6eb307d6-3567-481a-971a-feb666b8ae72")]
	public interface mozISpellCheckingEngine
	{
		
		/// <summary>
        /// The name of the current dictionary
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDictionaryAttribute();
		
		/// <summary>
        /// The name of the current dictionary
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDictionaryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string aDictionary);
		
		/// <summary>
        /// The language this spellchecker is using when checking
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetLanguageAttribute();
		
		/// <summary>
        /// Does the engine provide its own personal dictionary?
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProvidesPersonalDictionaryAttribute();
		
		/// <summary>
        /// Does the engine provide its own word utils?
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProvidesWordUtilsAttribute();
		
		/// <summary>
        /// The name of the engine
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetNameAttribute();
		
		/// <summary>
        /// a string indicating the copyright of the engine
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCopyrightAttribute();
		
		/// <summary>
        /// the personal dictionary
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIPersonalDictionary GetPersonalDictionaryAttribute();
		
		/// <summary>
        /// the personal dictionary
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersonalDictionaryAttribute(mozIPersonalDictionary aPersonalDictionary);
		
		/// <summary>
        /// Get the list of dictionaries
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDictionaryList([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] dictionaries, ref uint count);
		
		/// <summary>
        /// check a word
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string word);
		
		/// <summary>
        /// get a list of suggestions for a misspelled word
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suggest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")] string word, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] ref System.IntPtr[] suggestions, ref uint count);
		
		/// <summary>
        /// Load dictionaries from the specified dir
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadDictionariesFromDir([MarshalAs(UnmanagedType.Interface)] nsIFile dir);
	}
}
