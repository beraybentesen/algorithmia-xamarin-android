using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoAsyncResponse']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/AlgoAsyncResponse", DoNotGenerateAcw=true)]
	public partial class AlgoAsyncResponse : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/algo/AlgoAsyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgoAsyncResponse); }
		}

		protected AlgoAsyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoAsyncResponse']/constructor[@name='AlgoAsyncResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AlgoAsyncResponse (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (AlgoAsyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAsyncProtocol;
#pragma warning disable 0169
		static Delegate GetGetAsyncProtocolHandler ()
		{
			if (cb_getAsyncProtocol == null)
				cb_getAsyncProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsyncProtocol);
			return cb_getAsyncProtocol;
		}

		static IntPtr n_GetAsyncProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoAsyncResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoAsyncResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsyncProtocol);
		}
#pragma warning restore 0169

		static IntPtr id_getAsyncProtocol;
		public virtual unsafe string AsyncProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoAsyncResponse']/method[@name='getAsyncProtocol' and count(parameter)=0]"
			[Register ("getAsyncProtocol", "()Ljava/lang/String;", "GetGetAsyncProtocolHandler")]
			get {
				if (id_getAsyncProtocol == IntPtr.Zero)
					id_getAsyncProtocol = JNIEnv.GetMethodID (class_ref, "getAsyncProtocol", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsyncProtocol), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsyncProtocol", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoAsyncResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoAsyncResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoAsyncResponse']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
