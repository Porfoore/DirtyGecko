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
// Generated by IDLImporter from file nsITaskbarProgress.idl
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
    /// Starting in Windows 7, applications can display a progress notification in
    /// the taskbar. This class wraps around the native functionality to do this.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("23ac257d-ef3c-4033-b424-be7fef91a86c")]
	public interface nsITaskbarProgress
	{
		
		/// <summary>
        /// Sets the taskbar progress state and value for this window. The currentValue
        /// and maxValue parameters are optional and should be supplied when |state|
        /// is one of STATE_NORMAL, STATE_ERROR or STATE_PAUSED.
        ///
        /// @throws NS_ERROR_INVALID_ARG if state is STATE_NO_PROGRESS or
        /// STATE_INDETERMINATE, and either currentValue or maxValue is not 0.
        /// @throws NS_ERROR_ILLEGAL_VALUE if currentValue is greater than maxValue.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProgressState(System.IntPtr state, uint currentValue, uint maxValue);
	}
}
