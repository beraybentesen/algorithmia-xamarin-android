using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpRequest", DoNotGenerateAcw=true)]
	public partial class HttpRequest : global::Java.Lang.Object {


		static IntPtr connection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/field[@name='connection']"
		[Register ("connection")]
		protected global::Java.Net.HttpURLConnection Connection {
			get {
				if (connection_jfieldId == IntPtr.Zero)
					connection_jfieldId = JNIEnv.GetFieldID (class_ref, "connection", "Ljava/net/HttpURLConnection;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, connection_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connection_jfieldId == IntPtr.Zero)
					connection_jfieldId = JNIEnv.GetFieldID (class_ref, "connection", "Ljava/net/HttpURLConnection;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, connection_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequest); }
		}

		protected HttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe HttpRequest (string p0, string p1)
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
				if (GetType () != typeof (HttpRequest)) {
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

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Algorithmia.Client.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Client.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Lcom/algorithmia/client/HttpResponse;", "GetExecuteHandler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Lcom/algorithmia/client/HttpResponse;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()Lcom/algorithmia/client/HttpResponse;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute_Lcom_algorithmia_client_HttpResponseHandler_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_algorithmia_client_HttpResponseHandler_Handler ()
		{
			if (cb_execute_Lcom_algorithmia_client_HttpResponseHandler_ == null)
				cb_execute_Lcom_algorithmia_client_HttpResponseHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_algorithmia_client_HttpResponseHandler_);
			return cb_execute_Lcom_algorithmia_client_HttpResponseHandler_;
		}

		static IntPtr n_Execute_Lcom_algorithmia_client_HttpResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpResponseHandler p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponseHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_algorithmia_client_HttpResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponseHandler&lt;T&gt;']]"
		[Register ("execute", "(Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;", "GetExecute_Lcom_algorithmia_client_HttpResponseHandler_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Execute (global::Com.Algorithmia.Client.HttpResponseHandler p0)
		{
			if (id_execute_Lcom_algorithmia_client_HttpResponseHandler_ == IntPtr.Zero)
				id_execute_Lcom_algorithmia_client_HttpResponseHandler_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_algorithmia_client_HttpResponseHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setEntity_Lcom_algorithmia_client_HttpEntity_;
#pragma warning disable 0169
		static Delegate GetSetEntity_Lcom_algorithmia_client_HttpEntity_Handler ()
		{
			if (cb_setEntity_Lcom_algorithmia_client_HttpEntity_ == null)
				cb_setEntity_Lcom_algorithmia_client_HttpEntity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntity_Lcom_algorithmia_client_HttpEntity_);
			return cb_setEntity_Lcom_algorithmia_client_HttpEntity_;
		}

		static void n_SetEntity_Lcom_algorithmia_client_HttpEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEntity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEntity_Lcom_algorithmia_client_HttpEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpRequest']/method[@name='setEntity' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpEntity']]"
		[Register ("setEntity", "(Lcom/algorithmia/client/HttpEntity;)V", "GetSetEntity_Lcom_algorithmia_client_HttpEntity_Handler")]
		protected virtual unsafe void SetEntity (global::Com.Algorithmia.Client.HttpEntity p0)
		{
			if (id_setEntity_Lcom_algorithmia_client_HttpEntity_ == IntPtr.Zero)
				id_setEntity_Lcom_algorithmia_client_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "setEntity", "(Lcom/algorithmia/client/HttpEntity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntity_Lcom_algorithmia_client_HttpEntity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntity", "(Lcom/algorithmia/client/HttpEntity;)V"), __args);
			} finally {
			}
		}

	}
}
