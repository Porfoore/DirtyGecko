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
// Generated by IDLImporter from file nsIDOMWebGLRenderingContext.idl
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
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0df9f4ed-f5ff-4e51-a6ff-2bd9785a7639")]
	public interface nsIWebGLTexture
	{
		
		/// <summary>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLBuffer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9eca9c32-8305-11de-b89b-000c29206271")]
	public interface nsIWebGLBuffer
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLProgram </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6a19e74-8305-11de-9ce9-000c29206271")]
	public interface nsIWebGLProgram
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLShader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ac7440a4-8305-11de-807b-000c29206271")]
	public interface nsIWebGLShader
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLShaderArray </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("beea4b38-3094-4e8d-b6e6-8b21d07e8994")]
	public interface nsIWebGLShaderArray
	{
		
		/// <summary>Member GetLengthAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		/// <summary>Member Item </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIWebGLShader</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLShader Item(uint index);
	}
	
	/// <summary>nsIWebGLFramebuffer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bce8be60-8305-11de-9f3c-000c29206271")]
	public interface nsIWebGLFramebuffer
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLRenderbuffer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c82eacd0-8305-11de-9de9-000c29206271")]
	public interface nsIWebGLRenderbuffer
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(uint aName);
	}
	
	/// <summary>nsIWebGLActiveInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a85d4fd0-5b9f-4cb8-aeee-5a2c5c5bad76")]
	public interface nsIWebGLActiveInfo
	{
		
		/// <summary>Member GetSizeAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSizeAttribute();
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
	}
	
	/// <summary>nsIWebGLUniformLocation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d38b0467-623e-4c82-9140-5f14a3bd1bad")]
	public interface nsIWebGLUniformLocation
	{
		
		/// <summary>Member GetLocationAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLocationAttribute();
		
		/// <summary>Member SetLocationAttribute </summary>
		/// <param name='aLocation'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLocationAttribute(int aLocation);
	}
	
	/// <summary>
    ///Base class for all WebGL extensions, and for those without
    /// any additional tokens/methods.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("70814f32-a5c5-4b95-83d5-ac653bac3316")]
	public interface nsIWebGLExtension
	{
	}
	
	/// <summary>
    ///Base class for all WebGL extensions, and for those without
    /// any additional tokens/methods.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ef15ae85-4670-4dc4-848d-51ca81e8397a")]
	public interface nsIDOMWebGLRenderingContext
	{
		
		/// <summary>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCanvasElement GetCanvasAttribute();
		
		/// <summary>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetContextAttributes();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ActiveTexture(uint texture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttachShader([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindAttribLocation([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindBuffer(uint target, [MarshalAs(UnmanagedType.Interface)] nsIWebGLBuffer buffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindFramebuffer(uint target, [MarshalAs(UnmanagedType.Interface)] nsIWebGLFramebuffer framebuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindRenderbuffer(uint target, [MarshalAs(UnmanagedType.Interface)] nsIWebGLRenderbuffer renderbuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindTexture(uint target, [MarshalAs(UnmanagedType.Interface)] nsIWebGLTexture texture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlendColor(double red, double green, double blue, double alpha);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlendEquation(uint mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlendEquationSeparate(uint modeRGB, uint modeAlpha);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlendFunc(uint sfactor, uint dfactor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		
		/// <summary>
        /// Modified: void glBufferData(WebGLenum target, long size, const void* data, WebGLenum usage);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferData(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferData_size(uint target, int size, uint usage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferData_buf(uint target, System.IntPtr data, uint usage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferData_array(uint target, System.IntPtr data, uint usage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferData_null();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferSubData(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferSubData_buf(uint target, int offset, System.IntPtr data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferSubData_array(uint target, int offset, System.IntPtr data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BufferSubData_null();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint CheckFramebufferStatus(uint target);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear(uint mask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearColor(double red, double green, double blue, double alpha);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearDepth(double depth);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearStencil(int s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ColorMask(bool red, bool green, bool blue, bool alpha);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompileShader([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLBuffer CreateBuffer();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLProgram CreateProgram();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLFramebuffer CreateFramebuffer();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLRenderbuffer CreateRenderbuffer();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLShader CreateShader(uint type);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLTexture CreateTexture();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CullFace(uint mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteBuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLBuffer buffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteProgram([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteFramebuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLFramebuffer framebuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRenderbuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLRenderbuffer renderbuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteShader([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteTexture([MarshalAs(UnmanagedType.Interface)] nsIWebGLTexture texture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DepthFunc(uint func);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DepthMask(bool flag);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DepthRange(double zNear, double zFar);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DetachShader([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Disable(uint cap);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisableVertexAttribArray(uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DrawArrays(uint mode, int first, int count);
		
		/// <summary>
        /// Modified: void glDrawElements(WebGLenum mode, WebGLsizei count, WebGLenum type, const void* indices);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DrawElements(uint mode, int count, uint type, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Enable(uint cap);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnableVertexAttribArray(uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Flush();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, [MarshalAs(UnmanagedType.Interface)] nsIWebGLRenderbuffer renderbuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FramebufferTexture2D(uint target, uint attachment, uint textarget, [MarshalAs(UnmanagedType.Interface)] nsIWebGLTexture texture, int level);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrontFace(uint mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GenerateMipmap(uint target);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLActiveInfo GetActiveAttrib([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, uint index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLActiveInfo GetActiveUniform([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, uint index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetAttachedShaders([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAttribLocation([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetParameter(uint pname);
		
		/// <summary>
        /// Modified: void glGetBufferParameteriv(WebGLenum target, WebGLenum pname, WebGLint* params);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetBufferParameter(uint target, uint pname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetError();
		
		/// <summary>
        /// Modified: void glGetFramebufferAttachmentParameteriv(WebGLenum target, WebGLenum attachment, WebGLenum pname, WebGLint* params);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname);
		
		/// <summary>
        /// Modified: void glGetProgramiv(nsIWebGLProgram program, WebGLenum pname, WebGLint* params);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetProgramParameter([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, uint pname);
		
		/// <summary>
        /// Modified: void glGetProgramInfoLog(WebGLuint program, WebGLsizei bufsize, WebGLsizei* length, char* infolog);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProgramInfoLog([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        ///nsIWebGLIntArray getRenderbufferParameteriv(in WebGLenum target, in WebGLenum pname);
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetRenderbufferParameter(uint target, uint pname);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetShaderParameter([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader, uint pname);
		
		/// <summary>
        /// Modified: void glGetShaderInfoLog(WebGLuint shader, WebGLsizei bufsize, WebGLsizei* length, char* infolog);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetShaderInfoLog([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        ///void glGetShaderPrecisionFormat(WebGLenum shadertype, WebGLenum precisiontype, WebGLint* range, WebGLint* precision);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetShaderSource([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetTexParameter(uint target, uint pname);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetUniform([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLUniformLocation GetUniformLocation([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program, [MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetVertexAttrib(uint index, uint pname);
		
		/// <summary>
        /// void glGetVertexAttribPointerv(WebGLuint index, WebGLenum pname, void** pointer);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetVertexAttribOffset(uint index, uint pname);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Hint(uint target, uint mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsBuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLBuffer buffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFramebuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLFramebuffer framebuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsProgram([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsRenderbuffer([MarshalAs(UnmanagedType.Interface)] nsIWebGLRenderbuffer renderbuffer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsShader([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsTexture([MarshalAs(UnmanagedType.Interface)] nsIWebGLTexture texture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEnabled(uint cap);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LineWidth(double width);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LinkProgram([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PixelStorei(uint pname, int param);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PolygonOffset(double factor, double units);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadPixels(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadPixels_array(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadPixels_buf(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels);
		
		/// <summary>
        ///void glReleaseShaderCompiler();
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RenderbufferStorage(uint target, uint internalformat, int width, int height);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SampleCoverage(double value, bool invert);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Scissor(int x, int y, int width, int height);
		
		/// <summary>
        /// Modified: void glShaderSource(WebGLuint shader, WebGLsizei count, const char** string, const WebGLint* length);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShaderSource([MarshalAs(UnmanagedType.Interface)] nsIWebGLShader shader, [MarshalAs(UnmanagedType.LPStruct)] nsAString source);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilFunc(uint func, int @ref, uint mask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilFuncSeparate(uint face, uint func, int @ref, uint mask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilMask(uint mask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilMaskSeparate(uint face, uint mask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilOp(uint fail, uint zfail, uint zpass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexImage2D(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexImage2D_buf(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexImage2D_array(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexImage2D_imageData(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels);
		
		/// <summary>
        /// HTMLImageElement, HTMLCanvasElement, HTMLVideoElement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexImage2D_dom(uint target, int level, uint internalformat, uint format, uint type, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexSubImage2D(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexSubImage2D_buf(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexSubImage2D_array(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexSubImage2D_imageData(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels);
		
		/// <summary>
        /// HTMLImageElement, HTMLCanvasElement, HTMLVideoElement
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexSubImage2D_dom(uint target, int level, int xoffset, int yoffset, uint format, uint type, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
		
		/// <summary>
        /// Modified: This replaces glTexParameterf, glTexParameterfv, glTexParameteri and glTexParameteriv
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexParameterf(uint target, uint pname, double param);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TexParameteri(uint target, uint pname, int param);
		
		/// <summary>
        /// Modified: All the glUniform*v forms below are modified by replacing 'count' and 'v' with a nsIWebGLArray
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1f([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, double x);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1i([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, int x);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2f([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, double x, double y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2i([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, int x, int y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3f([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, double x, double y, double z);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3i([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, int x, int y, int z);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4f([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, double x, double y, double z, double w);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4i([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, int x, int y, int z, int w);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1iv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2iv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3iv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4iv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform1iv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform2iv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform3iv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Uniform4iv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, System.IntPtr v);
		
		/// <summary>
        /// Modified. These are modified by replacing 'count' and 'value' with a WebGLJSObjectPtr
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix2fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix3fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix4fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix2fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, bool transpose, System.IntPtr value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix3fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, bool transpose, System.IntPtr value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UniformMatrix4fv_array([MarshalAs(UnmanagedType.Interface)] nsIWebGLUniformLocation location, bool transpose, System.IntPtr value);
		
		/// <summary>
        ///ZZ void glUniformMatrix(in WebGLint location, in WebGLboolean transpose, in nsIWebGLMatrixStack value);
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UseProgram([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ValidateProgram([MarshalAs(UnmanagedType.Interface)] nsIWebGLProgram program);
		
		/// <summary>
        /// Modified: All the glVertexAttrib*v forms below are modified by replacing 'values' with a WebGLJSObjectPtr
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib1f(uint indx, double x);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib2f(uint indx, double x, double y);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib3f(uint indx, double x, double y, double z);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib4f(uint indx, double x, double y, double z, double w);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib1fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib2fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib3fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib4fv(int dummy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib1fv_array(uint indx, System.IntPtr values);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib2fv_array(uint indx, System.IntPtr values);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib3fv_array(uint indx, System.IntPtr values);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttrib4fv_array(uint indx, System.IntPtr values);
		
		/// <summary>
        /// size is number of elements per attrib; offset, stride are in bytes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VertexAttribPointer(uint idx, int size, uint type, bool normalized, int stride, System.IntPtr offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Viewport(int x, int y, int width, int height);
		
		/// <summary>
        /// the underlying renderer to the user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozGetUnderlyingParamString(uint pname, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// extensions
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebGLExtension GetExtension([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetSupportedExtensions();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsContextLost();
	}
}
