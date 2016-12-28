using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaClient']"
	[global::Android.Runtime.Register ("com/algorithmia/AlgorithmiaClient", DoNotGenerateAcw=true)]
	public sealed partial class AlgorithmiaClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/AlgorithmiaClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgorithmiaClient); }
		}

		internal AlgorithmiaClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_algo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaClient']/method[@name='algo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("algo", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm Algo (string p0)
		{
			if (id_algo_Ljava_lang_String_ == IntPtr.Zero)
				id_algo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "algo", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Algo.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_algo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dir_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaClient']/method[@name='dir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dir", "(Ljava/lang/String;)Lcom/algorithmia/data/DataDirectory;", "")]
		public unsafe global::Com.Algorithmia.Data.DataDirectory Dir (string p0)
		{
			if (id_dir_Ljava_lang_String_ == IntPtr.Zero)
				id_dir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dir", "(Ljava/lang/String;)Lcom/algorithmia/data/DataDirectory;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Data.DataDirectory __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dir_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_file_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia']/class[@name='AlgorithmiaClient']/method[@name='file' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("file", "(Ljava/lang/String;)Lcom/algorithmia/data/DataFile;", "")]
		public unsafe global::Com.Algorithmia.Data.DataFile File (string p0)
		{
			if (id_file_Ljava_lang_String_ == IntPtr.Zero)
				id_file_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "file", "(Ljava/lang/String;)Lcom/algorithmia/data/DataFile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Data.DataFile __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_file_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
