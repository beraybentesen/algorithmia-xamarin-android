using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpContentType']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpContentType", DoNotGenerateAcw=true)]
	public partial class HttpContentType : global::Java.Lang.Object {


		static IntPtr APPLICATION_JSON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpContentType']/field[@name='APPLICATION_JSON']"
		[Register ("APPLICATION_JSON")]
		public static global::Com.Algorithmia.Client.HttpContentType ApplicationJson {
			get {
				if (APPLICATION_JSON_jfieldId == IntPtr.Zero)
					APPLICATION_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_JSON", "Lcom/algorithmia/client/HttpContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_JSON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr APPLICATION_OCTET_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpContentType']/field[@name='APPLICATION_OCTET_STREAM']"
		[Register ("APPLICATION_OCTET_STREAM")]
		public static global::Com.Algorithmia.Client.HttpContentType ApplicationOctetStream {
			get {
				if (APPLICATION_OCTET_STREAM_jfieldId == IntPtr.Zero)
					APPLICATION_OCTET_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_OCTET_STREAM", "Lcom/algorithmia/client/HttpContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_OCTET_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_PLAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpContentType']/field[@name='TEXT_PLAIN']"
		[Register ("TEXT_PLAIN")]
		public static global::Com.Algorithmia.Client.HttpContentType TextPlain {
			get {
				if (TEXT_PLAIN_jfieldId == IntPtr.Zero)
					TEXT_PLAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_PLAIN", "Lcom/algorithmia/client/HttpContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_PLAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpContentType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpContentType); }
		}

		protected HttpContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpContentType']/constructor[@name='HttpContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpContentType (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HttpContentType)) {
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

	}
}
