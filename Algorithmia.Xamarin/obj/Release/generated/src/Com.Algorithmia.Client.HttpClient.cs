using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpClient", DoNotGenerateAcw=true)]
	public partial class HttpClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClient); }
		}

		protected HttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_client_Auth_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/constructor[@name='HttpClient' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.Auth']]"
		[Register (".ctor", "(Lcom/algorithmia/client/Auth;)V", "")]
		public unsafe HttpClient (global::Com.Algorithmia.Client.Auth p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HttpClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/client/Auth;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/client/Auth;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_client_Auth_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_client_Auth_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/client/Auth;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_client_Auth_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_client_Auth_, __args);
			} finally {
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static IntPtr n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Delete (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Delete (string p0)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_ == null)
				cb_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_);
			return cb_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_;
		}

		static IntPtr n_Get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.TypeToken p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.TypeToken> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.TypeToken&lt;T&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("get", "(Ljava/lang/String;Lcom/algorithmia/TypeToken;Ljava/util/Map;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Get (string p0, global::Com.Algorithmia.TypeToken p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/algorithmia/TypeToken;Ljava/util/Map;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Lcom_algorithmia_TypeToken_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/algorithmia/TypeToken;Ljava/util/Map;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_head_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHead_Ljava_lang_String_Handler ()
		{
			if (cb_head_Ljava_lang_String_ == null)
				cb_head_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Head_Ljava_lang_String_);
			return cb_head_Ljava_lang_String_;
		}

		static IntPtr n_Head_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Head (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_head_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='head' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("head", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;", "GetHead_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Head (string p0)
		{
			if (id_head_Ljava_lang_String_ == IntPtr.Zero)
				id_head_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "head", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_head_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "head", "(Ljava/lang/String;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
#pragma warning disable 0169
		static Delegate GetPatch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler ()
		{
			if (cb_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == null)
				cb_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_);
			return cb_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		}

		static IntPtr n_Patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Patch (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='patch' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpEntity']]"
		[Register ("patch", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;", "GetPatch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Patch (string p0, global::Com.Algorithmia.Client.HttpEntity p1)
		{
			if (id_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == IntPtr.Zero)
				id_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "patch", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_patch_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "patch", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == null)
				cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_);
			return cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		}

		static IntPtr n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpEntity']]"
		[Register ("post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;", "GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Post (string p0, global::Com.Algorithmia.Client.HttpEntity p1)
		{
			if (id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_ == null)
				cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_);
			return cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_;
		}

		static IntPtr n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpResponseHandler p2 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='post' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpEntity'] and parameter[3][@type='com.algorithmia.client.HttpResponseHandler&lt;T&gt;']]"
		[Register ("post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;", "GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Post (string p0, global::Com.Algorithmia.Client.HttpEntity p1, global::Com.Algorithmia.Client.HttpResponseHandler p2)
		{
			if (id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_ == null)
				cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_);
			return cb_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_;
		}

		static IntPtr n_Post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpResponseHandler p2 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='post' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpEntity'] and parameter[3][@type='com.algorithmia.client.HttpResponseHandler&lt;T&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;Ljava/util/Map;)Ljava/lang/Object;", "GetPost_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Post (string p0, global::Com.Algorithmia.Client.HttpEntity p1, global::Com.Algorithmia.Client.HttpResponseHandler p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;Ljava/util/Map;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Lcom_algorithmia_client_HttpResponseHandler_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;Lcom/algorithmia/client/HttpResponseHandler;Ljava/util/Map;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == null)
				cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_);
			return cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		}

		static IntPtr n_Put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Algorithmia.Client.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpEntity p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpClient']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpEntity']]"
		[Register ("put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;", "GetPut_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_Handler")]
		public virtual unsafe global::Com.Algorithmia.Client.HttpResponse Put (string p0, global::Com.Algorithmia.Client.HttpEntity p1)
		{
			if (id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Algorithmia.Client.HttpResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpEntity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpEntity;)Lcom/algorithmia/client/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
