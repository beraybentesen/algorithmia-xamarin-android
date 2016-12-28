using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia']/class[@name='Algorithmia']"
	[global::Android.Runtime.Register ("com/algorithmia/Algorithmia", DoNotGenerateAcw=true)]
	public sealed partial class Algorithmia : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/Algorithmia", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Algorithmia); }
		}

		internal Algorithmia (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_client;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='Algorithmia']/method[@name='client' and count(parameter)=0]"
		[Register ("client", "()Lcom/algorithmia/AlgorithmiaClient;", "")]
		public static unsafe global::Com.Algorithmia.AlgorithmiaClient Client ()
		{
			if (id_client == IntPtr.Zero)
				id_client = JNIEnv.GetStaticMethodID (class_ref, "client", "()Lcom/algorithmia/AlgorithmiaClient;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.AlgorithmiaClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_client), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_client_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='Algorithmia']/method[@name='client' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("client", "(I)Lcom/algorithmia/AlgorithmiaClient;", "")]
		public static unsafe global::Com.Algorithmia.AlgorithmiaClient Client (int p0)
		{
			if (id_client_I == IntPtr.Zero)
				id_client_I = JNIEnv.GetStaticMethodID (class_ref, "client", "(I)Lcom/algorithmia/AlgorithmiaClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.AlgorithmiaClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_client_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_client_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='Algorithmia']/method[@name='client' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("client", "(Ljava/lang/String;)Lcom/algorithmia/AlgorithmiaClient;", "")]
		public static unsafe global::Com.Algorithmia.AlgorithmiaClient Client (string p0)
		{
			if (id_client_Ljava_lang_String_ == IntPtr.Zero)
				id_client_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "client", "(Ljava/lang/String;)Lcom/algorithmia/AlgorithmiaClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.AlgorithmiaClient __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.AlgorithmiaClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_client_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_client_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='Algorithmia']/method[@name='client' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("client", "(Ljava/lang/String;I)Lcom/algorithmia/AlgorithmiaClient;", "")]
		public static unsafe global::Com.Algorithmia.AlgorithmiaClient Client (string p0, int p1)
		{
			if (id_client_Ljava_lang_String_I == IntPtr.Zero)
				id_client_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "client", "(Ljava/lang/String;I)Lcom/algorithmia/AlgorithmiaClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Algorithmia.AlgorithmiaClient __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.AlgorithmiaClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_client_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
