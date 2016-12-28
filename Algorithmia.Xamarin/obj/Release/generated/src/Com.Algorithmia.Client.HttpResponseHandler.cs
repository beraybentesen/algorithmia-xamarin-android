using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpResponseHandler", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class HttpResponseHandler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler.JsonDeserializeResponseHandler']"
		[global::Android.Runtime.Register ("com/algorithmia/client/HttpResponseHandler$JsonDeserializeResponseHandler", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S"})]
		public partial class JsonDeserializeResponseHandler : global::Com.Algorithmia.Client.HttpResponseHandler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/client/HttpResponseHandler$JsonDeserializeResponseHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JsonDeserializeResponseHandler); }
			}

			protected JsonDeserializeResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_algorithmia_TypeToken_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler.JsonDeserializeResponseHandler']/constructor[@name='HttpResponseHandler.JsonDeserializeResponseHandler' and count(parameter)=1 and parameter[1][@type='com.algorithmia.TypeToken&lt;S&gt;']]"
			[Register (".ctor", "(Lcom/algorithmia/TypeToken;)V", "")]
			public unsafe JsonDeserializeResponseHandler (global::Com.Algorithmia.TypeToken p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (JsonDeserializeResponseHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/TypeToken;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/TypeToken;)V", __args);
						return;
					}

					if (id_ctor_Lcom_algorithmia_TypeToken_ == IntPtr.Zero)
						id_ctor_Lcom_algorithmia_TypeToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/TypeToken;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_TypeToken_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_TypeToken_, __args);
				} finally {
				}
			}

			static Delegate cb_handleResponse_Lcom_algorithmia_client_HttpResponse_;
#pragma warning disable 0169
			static Delegate GetHandleResponse_Lcom_algorithmia_client_HttpResponse_Handler ()
			{
				if (cb_handleResponse_Lcom_algorithmia_client_HttpResponse_ == null)
					cb_handleResponse_Lcom_algorithmia_client_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleResponse_Lcom_algorithmia_client_HttpResponse_);
				return cb_handleResponse_Lcom_algorithmia_client_HttpResponse_;
			}

			static IntPtr n_HandleResponse_Lcom_algorithmia_client_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Algorithmia.Client.HttpResponseHandler.JsonDeserializeResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponseHandler.JsonDeserializeResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Algorithmia.Client.HttpResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HandleResponse (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_handleResponse_Lcom_algorithmia_client_HttpResponse_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler.JsonDeserializeResponseHandler']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
			[Register ("handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;", "GetHandleResponse_Lcom_algorithmia_client_HttpResponse_Handler")]
			protected override unsafe global::Java.Lang.Object HandleResponse (global::Com.Algorithmia.Client.HttpResponse p0)
			{
				if (id_handleResponse_Lcom_algorithmia_client_HttpResponse_ == IntPtr.Zero)
					id_handleResponse_Lcom_algorithmia_client_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Lcom_algorithmia_client_HttpResponse_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponseHandler); }
		}

		protected HttpResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler']/constructor[@name='HttpResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpResponseHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpResponseHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_handleResponse_Lcom_algorithmia_client_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetHandleResponse_Lcom_algorithmia_client_HttpResponse_Handler ()
		{
			if (cb_handleResponse_Lcom_algorithmia_client_HttpResponse_ == null)
				cb_handleResponse_Lcom_algorithmia_client_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleResponse_Lcom_algorithmia_client_HttpResponse_);
			return cb_handleResponse_Lcom_algorithmia_client_HttpResponse_;
		}

		static IntPtr n_HandleResponse_Lcom_algorithmia_client_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HandleResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
		[Register ("handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;", "GetHandleResponse_Lcom_algorithmia_client_HttpResponse_Handler")]
		protected abstract global::Java.Lang.Object HandleResponse (global::Com.Algorithmia.Client.HttpResponse p0);

	}

	[global::Android.Runtime.Register ("com/algorithmia/client/HttpResponseHandler", DoNotGenerateAcw=true)]
	internal partial class HttpResponseHandlerInvoker : HttpResponseHandler {

		public HttpResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponseHandlerInvoker); }
		}

		static IntPtr id_handleResponse_Lcom_algorithmia_client_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpResponseHandler']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='com.algorithmia.client.HttpResponse']]"
		[Register ("handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;", "GetHandleResponse_Lcom_algorithmia_client_HttpResponse_Handler")]
		protected override unsafe global::Java.Lang.Object HandleResponse (global::Com.Algorithmia.Client.HttpResponse p0)
		{
			if (id_handleResponse_Lcom_algorithmia_client_HttpResponse_ == IntPtr.Zero)
				id_handleResponse_Lcom_algorithmia_client_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Lcom/algorithmia/client/HttpResponse;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Lcom_algorithmia_client_HttpResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
