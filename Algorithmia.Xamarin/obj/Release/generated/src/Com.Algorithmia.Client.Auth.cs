using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='Auth']"
	[global::Android.Runtime.Register ("com/algorithmia/client/Auth", DoNotGenerateAcw=true)]
	public abstract partial class Auth : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/Auth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Auth); }
		}

		protected Auth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='Auth']/constructor[@name='Auth' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Auth ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Auth)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_authenticateRequest_Lcom_algorithmia_client_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetAuthenticateRequest_Lcom_algorithmia_client_HttpRequest_Handler ()
		{
			if (cb_authenticateRequest_Lcom_algorithmia_client_HttpRequest_ == null)
				cb_authenticateRequest_Lcom_algorithmia_client_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AuthenticateRequest_Lcom_algorithmia_client_HttpRequest_);
			return cb_authenticateRequest_Lcom_algorithmia_client_HttpRequest_;
		}

		static void n_AuthenticateRequest_Lcom_algorithmia_client_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.Auth __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.Auth> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthenticateRequest (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='Auth']/method[@name='authenticateRequest' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpRequest']]"
		[Register ("authenticateRequest", "(Lcom/algorithmia/client/HttpRequest;)V", "GetAuthenticateRequest_Lcom_algorithmia_client_HttpRequest_Handler")]
		protected abstract void AuthenticateRequest (global::Com.Algorithmia.Client.HttpRequest p0);

	}

	[global::Android.Runtime.Register ("com/algorithmia/client/Auth", DoNotGenerateAcw=true)]
	internal partial class AuthInvoker : Auth {

		public AuthInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthInvoker); }
		}

		static IntPtr id_authenticateRequest_Lcom_algorithmia_client_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='Auth']/method[@name='authenticateRequest' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpRequest']]"
		[Register ("authenticateRequest", "(Lcom/algorithmia/client/HttpRequest;)V", "GetAuthenticateRequest_Lcom_algorithmia_client_HttpRequest_Handler")]
		protected override unsafe void AuthenticateRequest (global::Com.Algorithmia.Client.HttpRequest p0)
		{
			if (id_authenticateRequest_Lcom_algorithmia_client_HttpRequest_ == IntPtr.Zero)
				id_authenticateRequest_Lcom_algorithmia_client_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "authenticateRequest", "(Lcom/algorithmia/client/HttpRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticateRequest_Lcom_algorithmia_client_HttpRequest_, __args);
			} finally {
			}
		}

	}

}
