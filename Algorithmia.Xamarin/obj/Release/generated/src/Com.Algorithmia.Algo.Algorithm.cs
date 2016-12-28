using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/Algorithm", DoNotGenerateAcw=true)]
	public sealed partial class Algorithm : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']"
		[global::Android.Runtime.Register ("com/algorithmia/algo/Algorithm$AlgorithmOptions", DoNotGenerateAcw=true)]
		public sealed partial class AlgorithmOptions : global::Java.Lang.Enum {


			static IntPtr OUTPUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']/field[@name='OUTPUT']"
			[Register ("OUTPUT")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions Output {
				get {
					if (OUTPUT_jfieldId == IntPtr.Zero)
						OUTPUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUTPUT", "Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUTPUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STDOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']/field[@name='STDOUT']"
			[Register ("STDOUT")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions Stdout {
				get {
					if (STDOUT_jfieldId == IntPtr.Zero)
						STDOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STDOUT", "Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STDOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']/field[@name='TIMEOUT']"
			[Register ("TIMEOUT")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions Timeout {
				get {
					if (TIMEOUT_jfieldId == IntPtr.Zero)
						TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT", "Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/algo/Algorithm$AlgorithmOptions", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AlgorithmOptions); }
			}

			internal AlgorithmOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;", "")]
			public static unsafe global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOptions']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;", "")]
			public static unsafe global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/algorithmia/algo/Algorithm$AlgorithmOptions;");
				try {
					return (global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Algorithmia.Algo.Algorithm.AlgorithmOptions));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']"
		[global::Android.Runtime.Register ("com/algorithmia/algo/Algorithm$AlgorithmOutputType", DoNotGenerateAcw=true)]
		public sealed partial class AlgorithmOutputType : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RAW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/field[@name='RAW']"
			[Register ("RAW")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType Raw {
				get {
					if (RAW_jfieldId == IntPtr.Zero)
						RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RAW", "Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RAW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/field[@name='VOID']"
			[Register ("VOID")]
			public static global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType Void {
				get {
					if (VOID_jfieldId == IntPtr.Zero)
						VOID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOID", "Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/algo/Algorithm$AlgorithmOutputType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AlgorithmOutputType); }
			}

			internal AlgorithmOutputType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_fromParameter_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/method[@name='fromParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromParameter", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;", "")]
			public static unsafe global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType FromParameter (string p0)
			{
				if (id_fromParameter_Ljava_lang_String_ == IntPtr.Zero)
					id_fromParameter_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromParameter", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromParameter_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;", "")]
			public static unsafe global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm.AlgorithmOutputType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;", "")]
			public static unsafe global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;");
				try {
					return (global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/algo/Algorithm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Algorithm); }
		}

		internal Algorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/constructor[@name='Algorithm' and count(parameter)=2 and parameter[1][@type='com.algorithmia.client.HttpClient'] and parameter[2][@type='com.algorithmia.algo.AlgorithmRef']]"
		[Register (".ctor", "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;)V", "")]
		public unsafe Algorithm (global::Com.Algorithmia.Client.HttpClient p0, global::Com.Algorithmia.Algo.AlgorithmRef p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Algorithm)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/constructor[@name='Algorithm' and count(parameter)=3 and parameter[1][@type='com.algorithmia.client.HttpClient'] and parameter[2][@type='com.algorithmia.algo.AlgorithmRef'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;Ljava/util/Map;)V", "")]
		public unsafe Algorithm (global::Com.Algorithmia.Client.HttpClient p0, global::Com.Algorithmia.Algo.AlgorithmRef p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Algorithm)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/client/HttpClient;Lcom/algorithmia/algo/AlgorithmRef;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Lcom_algorithmia_algo_AlgorithmRef_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_pipe_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='pipe' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("pipe", "(Ljava/lang/Object;)Lcom/algorithmia/algo/AlgoResponse;", "")]
		public unsafe global::Com.Algorithmia.Algo.AlgoResponse Pipe (global::Java.Lang.Object p0)
		{
			if (id_pipe_Ljava_lang_Object_ == IntPtr.Zero)
				id_pipe_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pipe", "(Ljava/lang/Object;)Lcom/algorithmia/algo/AlgoResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Algorithmia.Algo.AlgoResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pipe_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pipeJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='pipeJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pipeJson", "(Ljava/lang/String;)Lcom/algorithmia/algo/AlgoResponse;", "")]
		public unsafe global::Com.Algorithmia.Algo.AlgoResponse PipeJson (string p0)
		{
			if (id_pipeJson_Ljava_lang_String_ == IntPtr.Zero)
				id_pipeJson_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "pipeJson", "(Ljava/lang/String;)Lcom/algorithmia/algo/AlgoResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Algo.AlgoResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pipeJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setOption_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='setOption' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm SetOption (string p0, string p1)
		{
			if (id_setOption_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setOption_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/algorithmia/algo/Algorithm;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Algorithmia.Algo.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOption_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setOptions_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setOptions", "(Ljava/util/Map;)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm SetOptions (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setOptions_Ljava_util_Map_ == IntPtr.Zero)
				id_setOptions_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Ljava/util/Map;)Lcom/algorithmia/algo/Algorithm;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Algo.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setOutputType_Lcom_algorithmia_algo_Algorithm_AlgorithmOutputType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='setOutputType' and count(parameter)=1 and parameter[1][@type='com.algorithmia.algo.Algorithm.AlgorithmOutputType']]"
		[Register ("setOutputType", "(Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm SetOutputType (global::Com.Algorithmia.Algo.Algorithm.AlgorithmOutputType p0)
		{
			if (id_setOutputType_Lcom_algorithmia_algo_Algorithm_AlgorithmOutputType_ == IntPtr.Zero)
				id_setOutputType_Lcom_algorithmia_algo_Algorithm_AlgorithmOutputType_ = JNIEnv.GetMethodID (class_ref, "setOutputType", "(Lcom/algorithmia/algo/Algorithm$AlgorithmOutputType;)Lcom/algorithmia/algo/Algorithm;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Algorithmia.Algo.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOutputType_Lcom_algorithmia_algo_Algorithm_AlgorithmOutputType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setStdout_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='setStdout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStdout", "(Z)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm SetStdout (bool p0)
		{
			if (id_setStdout_Z == IntPtr.Zero)
				id_setStdout_Z = JNIEnv.GetMethodID (class_ref, "setStdout", "(Z)Lcom/algorithmia/algo/Algorithm;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStdout_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setTimeout_Ljava_lang_Long_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='Algorithm']/method[@name='setTimeout' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("setTimeout", "(Ljava/lang/Long;Ljava/util/concurrent/TimeUnit;)Lcom/algorithmia/algo/Algorithm;", "")]
		public unsafe global::Com.Algorithmia.Algo.Algorithm SetTimeout (global::Java.Lang.Long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_setTimeout_Ljava_lang_Long_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_setTimeout_Ljava_lang_Long_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "setTimeout", "(Ljava/lang/Long;Ljava/util/concurrent/TimeUnit;)Lcom/algorithmia/algo/Algorithm;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Algorithmia.Algo.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Algorithm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_Ljava_lang_Long_Ljava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
