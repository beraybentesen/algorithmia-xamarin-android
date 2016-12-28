using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClientHelpers']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpClientHelpers", DoNotGenerateAcw=true)]
	public partial class HttpClientHelpers : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpClientHelpers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientHelpers); }
		}

		protected HttpClientHelpers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_jsonToAlgoResponse_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClientHelpers']/method[@name='jsonToAlgoResponse' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("jsonToAlgoResponse", "(Lcom/google/gson/JsonElement;)Lcom/algorithmia/algo/AlgoResponse;", "")]
		public static unsafe global::Com.Algorithmia.Algo.AlgoResponse JsonToAlgoResponse (global::GoogleGson.JsonElement p0)
		{
			if (id_jsonToAlgoResponse_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_jsonToAlgoResponse_Lcom_google_gson_JsonElement_ = JNIEnv.GetStaticMethodID (class_ref, "jsonToAlgoResponse", "(Lcom/google/gson/JsonElement;)Lcom/algorithmia/algo/AlgoResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Algorithmia.Algo.AlgoResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonToAlgoResponse_Lcom_google_gson_JsonElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseRawOutput_Lcom_algorithmia_client_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClientHelpers']/method[@name='parseRawOutput' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
		[Register ("parseRawOutput", "(Lcom/algorithmia/client/HttpResponse;)Lcom/algorithmia/algo/AlgoResponse;", "")]
		public static unsafe global::Com.Algorithmia.Algo.AlgoResponse ParseRawOutput (global::Com.Algorithmia.Client.HttpResponse p0)
		{
			if (id_parseRawOutput_Lcom_algorithmia_client_HttpResponse_ == IntPtr.Zero)
				id_parseRawOutput_Lcom_algorithmia_client_HttpResponse_ = JNIEnv.GetStaticMethodID (class_ref, "parseRawOutput", "(Lcom/algorithmia/client/HttpResponse;)Lcom/algorithmia/algo/AlgoResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Algorithmia.Algo.AlgoResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseRawOutput_Lcom_algorithmia_client_HttpResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseResponseJson_Lcom_algorithmia_client_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClientHelpers']/method[@name='parseResponseJson' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
		[Register ("parseResponseJson", "(Lcom/algorithmia/client/HttpResponse;)Lcom/google/gson/JsonElement;", "")]
		public static unsafe global::GoogleGson.JsonElement ParseResponseJson (global::Com.Algorithmia.Client.HttpResponse p0)
		{
			if (id_parseResponseJson_Lcom_algorithmia_client_HttpResponse_ == IntPtr.Zero)
				id_parseResponseJson_Lcom_algorithmia_client_HttpResponse_ = JNIEnv.GetStaticMethodID (class_ref, "parseResponseJson", "(Lcom/algorithmia/client/HttpResponse;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::GoogleGson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseResponseJson_Lcom_algorithmia_client_HttpResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_throwIfNotOk_Lcom_algorithmia_client_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClientHelpers']/method[@name='throwIfNotOk' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
		[Register ("throwIfNotOk", "(Lcom/algorithmia/client/HttpResponse;)V", "")]
		public static unsafe void ThrowIfNotOk (global::Com.Algorithmia.Client.HttpResponse p0)
		{
			if (id_throwIfNotOk_Lcom_algorithmia_client_HttpResponse_ == IntPtr.Zero)
				id_throwIfNotOk_Lcom_algorithmia_client_HttpResponse_ = JNIEnv.GetStaticMethodID (class_ref, "throwIfNotOk", "(Lcom/algorithmia/client/HttpResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwIfNotOk_Lcom_algorithmia_client_HttpResponse_, __args);
			} finally {
			}
		}

	}
}
