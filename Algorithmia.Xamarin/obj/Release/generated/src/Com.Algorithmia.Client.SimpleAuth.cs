using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='SimpleAuth']"
	[global::Android.Runtime.Register ("com/algorithmia/client/SimpleAuth", DoNotGenerateAcw=true)]
	public sealed partial class SimpleAuth : global::Com.Algorithmia.Client.Auth {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/SimpleAuth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleAuth); }
		}

		internal SimpleAuth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='SimpleAuth']/constructor[@name='SimpleAuth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SimpleAuth (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (SimpleAuth)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_authenticateRequest_Lcom_algorithmia_client_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='SimpleAuth']/method[@name='authenticateRequest' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpRequest']]"
		[Register ("authenticateRequest", "(Lcom/algorithmia/client/HttpRequest;)V", "")]
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
