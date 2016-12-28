using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaConf']"
	[global::Android.Runtime.Register ("com/algorithmia/AlgorithmiaConf", DoNotGenerateAcw=true)]
	public sealed partial class AlgorithmiaConf : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/AlgorithmiaConf", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgorithmiaConf); }
		}

		internal AlgorithmiaConf (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_apiAddress;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaConf']/method[@name='apiAddress' and count(parameter)=0]"
		[Register ("apiAddress", "()Ljava/lang/String;", "")]
		public static unsafe string ApiAddress ()
		{
			if (id_apiAddress == IntPtr.Zero)
				id_apiAddress = JNIEnv.GetStaticMethodID (class_ref, "apiAddress", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apiAddress), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_apiKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaConf']/method[@name='apiKey' and count(parameter)=0]"
		[Register ("apiKey", "()Ljava/lang/String;", "")]
		protected static unsafe string ApiKey ()
		{
			if (id_apiKey == IntPtr.Zero)
				id_apiKey = JNIEnv.GetStaticMethodID (class_ref, "apiKey", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_apiKey), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
