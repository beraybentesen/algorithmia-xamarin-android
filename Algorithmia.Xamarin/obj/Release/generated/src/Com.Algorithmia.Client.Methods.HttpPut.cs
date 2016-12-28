using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client.Methods {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client.methods']/class[@name='HttpPut']"
	[global::Android.Runtime.Register ("com/algorithmia/client/methods/HttpPut", DoNotGenerateAcw=true)]
	public partial class HttpPut : global::Com.Algorithmia.Client.HttpRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/methods/HttpPut", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpPut); }
		}

		protected HttpPut (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client.methods']/class[@name='HttpPut']/constructor[@name='HttpPut' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpPut (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HttpPut)) {
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

		static Delegate cb_setEntity_Lcom_algorithmia_client_HttpEntity_;
#pragma warning disable 0169
		static Delegate GetSetEntity_Lcom_algorithmia_client_HttpEntity_Handler ()
		{
			if (cb_setEntity_Lcom_algorithmia_client_HttpEntity_ == null)
				cb_setEntity_Lcom_algorithmia_client_HttpEntity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntity_Lcom_algorithmia_client_HttpEntity_);
			return cb_setEntity_Lcom_algorithmia_client_HttpEntity_;
		}

		static void n_SetEntity_Lcom_algorithmia_client_HttpEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.Methods.HttpPut __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.Methods.HttpPut> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEntity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEntity_Lcom_algorithmia_client_HttpEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client.methods']/class[@name='HttpPut']/method[@name='setEntity' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpEntity']]"
		[Register ("setEntity", "(Lcom/algorithmia/client/HttpEntity;)V", "GetSetEntity_Lcom_algorithmia_client_HttpEntity_Handler")]
		public virtual unsafe void SetEntity (global::Com.Algorithmia.Client.HttpEntity p0)
		{
			if (id_setEntity_Lcom_algorithmia_client_HttpEntity_ == IntPtr.Zero)
				id_setEntity_Lcom_algorithmia_client_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "setEntity", "(Lcom/algorithmia/client/HttpEntity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntity_Lcom_algorithmia_client_HttpEntity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntity", "(Lcom/algorithmia/client/HttpEntity;)V"), __args);
			} finally {
			}
		}

	}
}
