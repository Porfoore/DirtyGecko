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
// Generated by IDLImporter from file imgIRequest.idl
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
    /// imgIRequest interface
    ///
    /// @author Stuart Parmenter <stuart@mozilla.com>
    /// @version 0.1
    /// @see imagelib2
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c3bf4e2a-f64b-4ac1-a84e-18631b1802ab")]
	public interface imgIRequest : nsIRequest
	{
		
		/// <summary>
        /// The name of the request.  Often this is the URI of the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Indicates whether the request is pending. nsIRequest::isPending is
        /// true when there is an outstanding asynchronous event that will make
        /// the request no longer be pending.  Requests do not necessarily start
        /// out pending; in some cases, requests have to be explicitly initiated
        /// (e.g. nsIChannel implementations are only pending once asyncOpen
        /// returns successfully).
        ///
        /// Requests can become pending multiple times during their lifetime.
        ///
        /// @return TRUE if the request has yet to reach completion.
        /// @return FALSE if the request has reached completion (e.g., after
        /// OnStopRequest has fired).
        /// @note Suspended requests are still considered pending.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>
        /// The error status associated with the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStatusAttribute();
		
		/// <summary>
        /// Cancels the current request.  This will close any open input or
        /// output streams and terminate any async requests.  Users should
        /// normally pass NS_BINDING_ABORTED, although other errors may also
        /// be passed.  The error passed in will become the value of the
        /// status attribute.
        ///
        /// Implementations must not send any notifications (e.g. via
        /// nsIRequestObserver) synchronously from this function. Similarly,
        /// removal from the load group (if any) must also happen asynchronously.
        ///
        /// Requests that use nsIStreamListener must not call onDataAvailable
        /// anymore after cancel has been called.
        ///
        /// @param aStatus the reason for canceling this request.
        ///
        /// NOTE: most nsIRequest implementations expect aStatus to be a
        /// failure code; however, some implementations may allow aStatus to
        /// be a success code such as NS_OK.  In general, aStatus should be
        /// a failure code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(int aStatus);
		
		/// <summary>
        /// Suspends the current request.  This may have the effect of closing
        /// any underlying transport (in order to free up resources), although
        /// any open streams remain logically opened and will continue delivering
        /// data when the transport is resumed.
        ///
        /// Calling cancel() on a suspended request must not send any
        /// notifications (such as onstopRequest) until the request is resumed.
        ///
        /// NOTE: some implementations are unable to immediately suspend, and
        /// may continue to deliver events already posted to an event queue. In
        /// general, callers should be capable of handling events even after
        /// suspending a request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>
        /// Resumes the current request.  This may have the effect of re-opening
        /// any underlying transport and will resume the delivery of data to
        /// any open streams.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(uint aLoadFlags);
		
		/// <summary>
        /// the image container...
        /// @return the image object associated with the request.
        /// @attention NEED DOCS
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetImageAttribute();
		
		/// <summary>
        /// Status flags of the STATUS_* variety.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetImageStatusAttribute();
		
		/// <summary>
        /// The URI the image load was started with.  Note that this might not be the
        /// actual URI for the image (e.g. if HTTP redirects happened during the
        /// load).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIDecoderObserver GetDecoderObserverAttribute();
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetMimeTypeAttribute();
		
		/// <summary>
        /// Clone this request; the returned request will have aObserver as the
        /// observer.  aObserver will be notified synchronously (before the clone()
        /// call returns) with all the notifications that have already been dispatched
        /// for this image load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIRequest Clone(imgIDecoderObserver aObserver);
		
		/// <summary>
        /// The principal gotten from the channel the image was loaded from.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrincipal GetImagePrincipalAttribute();
		
		/// <summary>
        /// The CORS mode that this image was loaded with.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetCORSModeAttribute();
		
		/// <summary>
        /// Cancels this request as in nsIRequest::Cancel(); further, also nulls out
        /// decoderObserver so it gets no further notifications from us.
        ///
        /// NOTE: You should not use this in any new code; instead, use cancel(). Note
        /// that cancel() is asynchronous, which means that some time after you call
        /// it, the listener/observer will get an OnStopRequest(). This means that, if
        /// you're the observer, you can't call cancel() from your destructor.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelAndForgetObserver(int aStatus);
		
		/// <summary>
        /// Requests a decode for the image.
        ///
        /// imgIContainer has a requestDecode() method, but callers may want to request
        /// a decode before the container has necessarily been instantiated. Calling
        /// requestDecode() on the imgIRequest simply forwards along the request if the
        /// container already exists, or calls it once it gets OnStartContainer if the
        /// container does not yet exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestDecode();
		
		/// <summary>
        /// Locks an image. If the image does not exist yet, locks it once it becomes
        /// available. The lock persists for the lifetime of the imgIRequest (until
        /// unlockImage is called) even if the underlying image changes.
        ///
        /// If you don't call unlockImage() by the time this imgIRequest goes away, it
        /// will be called for you automatically.
        ///
        /// @see imgIContainer::lockImage for documentation of the underlying call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockImage();
		
		/// <summary>
        /// Unlocks an image.
        ///
        /// @see imgIContainer::unlockImage for documentation of the underlying call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockImage();
		
		/// <summary>
        /// If this request is for an animated image, the method creates a new
        /// request which contains the current frame of the image.
        /// Otherwise returns the same request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIRequest GetStaticRequest();
		
		/// <summary>
        /// Requests that the image animate (if it has an animation).
        ///
        /// @see Image::IncrementAnimationConsumers for documentation of the underlying call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IncrementAnimationConsumers();
		
		/// <summary>
        /// Tell the image it can forget about a request that the image animate.
        ///
        /// @see Image::DecrementAnimationConsumers for documentation of the underlying call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecrementAnimationConsumers();
	}
}
