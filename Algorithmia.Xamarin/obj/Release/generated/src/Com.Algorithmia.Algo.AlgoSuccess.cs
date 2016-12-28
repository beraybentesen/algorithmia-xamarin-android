using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/AlgoSuccess", DoNotGenerateAcw=true)]
	public sealed partial class AlgoSuccess : global::Com.Algorithmia.Algo.AlgoResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/algo/AlgoSuccess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgoSuccess); }
		}

		internal AlgoSuccess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_JsonElement_Lcom_algorithmia_algo_Metadata_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/constructor[@name='AlgoSuccess' and count(parameter)=3 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.algorithmia.algo.Metadata'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/google/gson/JsonElement;Lcom/algorithmia/algo/Metadata;Ljava/lang/String;)V", "")]
		public unsafe AlgoSuccess (global::GoogleGson.JsonElement p0, global::Com.Algorithmia.Algo.Metadata p1, string p2)
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
				if (GetType () != typeof (AlgoSuccess)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/gson/JsonElement;Lcom/algorithmia/algo/Metadata;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/JsonElement;Lcom/algorithmia/algo/Metadata;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_JsonElement_Lcom_algorithmia_algo_Metadata_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_JsonElement_Lcom_algorithmia_algo_Metadata_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/JsonElement;Lcom/algorithmia/algo/Metadata;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_JsonElement_Lcom_algorithmia_algo_Metadata_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_JsonElement_Lcom_algorithmia_algo_Metadata_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_isFailure;
		public override unsafe bool IsFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='isFailure' and count(parameter)=0]"
			[Register ("isFailure", "()Z", "GetIsFailureHandler")]
			get {
				if (id_isFailure == IntPtr.Zero)
					id_isFailure = JNIEnv.GetMethodID (class_ref, "isFailure", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFailure);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccess;
		public override unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccess);
				} finally {
				}
			}
		}

		static IntPtr id_getMetadata;
		public override unsafe global::Com.Algorithmia.Algo.Metadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/algorithmia/algo/Metadata;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lcom/algorithmia/algo/Metadata;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Metadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRawOutput;
		public override unsafe string RawOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='getRawOutput' and count(parameter)=0]"
			[Register ("getRawOutput", "()Ljava/lang/String;", "GetGetRawOutputHandler")]
			get {
				if (id_getRawOutput == IntPtr.Zero)
					id_getRawOutput = JNIEnv.GetMethodID (class_ref, "getRawOutput", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawOutput), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_as_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("as", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected override unsafe global::Java.Lang.Object As (global::Java.Lang.Class p0)
		{
			if (id_as_Ljava_lang_Class_ == IntPtr.Zero)
				id_as_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "as", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("as", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected override unsafe global::Java.Lang.Object As (global::Java.Lang.Reflect.IType p0)
		{
			if (id_as_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_as_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "as", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asJsonString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='asJsonString' and count(parameter)=0]"
		[Register ("asJsonString", "()Ljava/lang/String;", "")]
		public override unsafe string AsJsonString ()
		{
			if (id_asJsonString == IntPtr.Zero)
				id_asJsonString = JNIEnv.GetMethodID (class_ref, "asJsonString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asJsonString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoSuccess']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "")]
		public override unsafe string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
