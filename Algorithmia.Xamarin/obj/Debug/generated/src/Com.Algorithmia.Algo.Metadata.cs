using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/Metadata", DoNotGenerateAcw=true)]
	public sealed partial class Metadata : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/algo/Metadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metadata); }
		}

		internal Metadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=2 and parameter[1][@type='com.algorithmia.algo.ContentType'] and parameter[2][@type='java.lang.Double']]"
		[Register (".ctor", "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;)V", "")]
		public unsafe Metadata (global::Com.Algorithmia.Algo.ContentType p0, global::Java.Lang.Double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Metadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=3 and parameter[1][@type='com.algorithmia.algo.ContentType'] and parameter[2][@type='java.lang.Double'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;Ljava/lang/String;)V", "")]
		public unsafe Metadata (global::Com.Algorithmia.Algo.ContentType p0, global::Java.Lang.Double p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Metadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/algo/ContentType;Ljava/lang/Double;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_algo_ContentType_Ljava_lang_Double_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getContentType;
		public unsafe global::Com.Algorithmia.Algo.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/algorithmia/algo/ContentType;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lcom/algorithmia/algo/ContentType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDuration;
		public unsafe global::Java.Lang.Double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()Ljava/lang/Double;", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()Ljava/lang/Double;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDuration), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStdout;
		public unsafe string Stdout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Metadata']/method[@name='getStdout' and count(parameter)=0]"
			[Register ("getStdout", "()Ljava/lang/String;", "GetGetStdoutHandler")]
			get {
				if (id_getStdout == IntPtr.Zero)
					id_getStdout = JNIEnv.GetMethodID (class_ref, "getStdout", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStdout), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
