using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpResponse", DoNotGenerateAcw=true)]
	public partial class HttpResponse : global::Java.Lang.Object {


		static IntPtr body_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/field[@name='body']"
		[Register ("body")]
		public global::System.IO.Stream Body {
			get {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/io/InputStream;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, body_jfieldId);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (body_jfieldId == IntPtr.Zero)
					body_jfieldId = JNIEnv.GetFieldID (class_ref, "body", "Ljava/io/InputStream;");
				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, body_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr headers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/field[@name='headers']"
		[Register ("headers")]
		public global::System.Collections.IDictionary Headers {
			get {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headers_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/field[@name='status']"
		[Register ("status")]
		public int Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponse); }
		}

		protected HttpResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_io_InputStream_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/constructor[@name='HttpResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.io.InputStream'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/io/InputStream;Ljava/util/Map;)V", "")]
		public unsafe HttpResponse (string p0, int p1, global::System.IO.Stream p2, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (HttpResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ILjava/io/InputStream;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILjava/io/InputStream;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_io_InputStream_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_io_InputStream_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/io/InputStream;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_io_InputStream_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_io_InputStream_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Client.HttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		public virtual unsafe global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Client.HttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFirstHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFirstHeader_Ljava_lang_String_Handler ()
		{
			if (cb_getFirstHeader_Ljava_lang_String_ == null)
				cb_getFirstHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFirstHeader_Ljava_lang_String_);
			return cb_getFirstHeader_Ljava_lang_String_;
		}

		static IntPtr n_GetFirstHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFirstHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstHeader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponse']/method[@name='getFirstHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstHeader", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFirstHeader_Ljava_lang_String_Handler")]
		public virtual unsafe string GetFirstHeader (string p0)
		{
			if (id_getFirstHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_getFirstHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFirstHeader", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstHeader", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
