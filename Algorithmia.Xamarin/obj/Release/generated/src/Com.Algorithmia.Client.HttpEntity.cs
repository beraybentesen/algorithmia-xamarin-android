using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity']"
	[global::Android.Runtime.Register ("com/algorithmia/client/HttpEntity", DoNotGenerateAcw=true)]
	public abstract partial class HttpEntity : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.ByteArrayEntity']"
		[global::Android.Runtime.Register ("com/algorithmia/client/HttpEntity$ByteArrayEntity", DoNotGenerateAcw=true)]
		public partial class ByteArrayEntity : global::Com.Algorithmia.Client.HttpEntity {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/client/HttpEntity$ByteArrayEntity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ByteArrayEntity); }
			}

			protected ByteArrayEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.ByteArrayEntity']/constructor[@name='HttpEntity.ByteArrayEntity' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe ByteArrayEntity (byte[] p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (ByteArrayEntity)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
						return;
					}

					if (id_ctor_arrayB == IntPtr.Zero)
						id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_ctor_arrayBLcom_algorithmia_client_HttpContentType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.ByteArrayEntity']/constructor[@name='HttpEntity.ByteArrayEntity' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.algorithmia.client.HttpContentType']]"
			[Register (".ctor", "([BLcom/algorithmia/client/HttpContentType;)V", "")]
			public unsafe ByteArrayEntity (byte[] p0, global::Com.Algorithmia.Client.HttpContentType p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ByteArrayEntity)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLcom/algorithmia/client/HttpContentType;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BLcom/algorithmia/client/HttpContentType;)V", __args);
						return;
					}

					if (id_ctor_arrayBLcom_algorithmia_client_HttpContentType_ == IntPtr.Zero)
						id_ctor_arrayBLcom_algorithmia_client_HttpContentType_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLcom/algorithmia/client/HttpContentType;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLcom_algorithmia_client_HttpContentType_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBLcom_algorithmia_client_HttpContentType_, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
			static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
			{
				if (cb_writeTo_Ljava_io_OutputStream_ == null)
					cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
				return cb_writeTo_Ljava_io_OutputStream_;
			}

			static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Algorithmia.Client.HttpEntity.ByteArrayEntity __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity.ByteArrayEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WriteTo (p0);
			}
#pragma warning restore 0169

			static IntPtr id_writeTo_Ljava_io_OutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.ByteArrayEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
			public override unsafe void WriteTo (global::System.IO.Stream p0)
			{
				if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTo_Ljava_io_OutputStream_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Ljava/io/OutputStream;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.InputStreamEntity']"
		[global::Android.Runtime.Register ("com/algorithmia/client/HttpEntity$InputStreamEntity", DoNotGenerateAcw=true)]
		public partial class InputStreamEntity : global::Com.Algorithmia.Client.HttpEntity {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/client/HttpEntity$InputStreamEntity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InputStreamEntity); }
			}

			protected InputStreamEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.InputStreamEntity']/constructor[@name='HttpEntity.InputStreamEntity' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public unsafe InputStreamEntity (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (InputStreamEntity)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_io_InputStream_Lcom_algorithmia_client_HttpContentType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.InputStreamEntity']/constructor[@name='HttpEntity.InputStreamEntity' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.algorithmia.client.HttpContentType']]"
			[Register (".ctor", "(Ljava/io/InputStream;Lcom/algorithmia/client/HttpContentType;)V", "")]
			public unsafe InputStreamEntity (global::System.IO.Stream p0, global::Com.Algorithmia.Client.HttpContentType p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (InputStreamEntity)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;Lcom/algorithmia/client/HttpContentType;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;Lcom/algorithmia/client/HttpContentType;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_Lcom_algorithmia_client_HttpContentType_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_Lcom_algorithmia_client_HttpContentType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Lcom/algorithmia/client/HttpContentType;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Lcom_algorithmia_client_HttpContentType_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_Lcom_algorithmia_client_HttpContentType_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
			static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
			{
				if (cb_writeTo_Ljava_io_OutputStream_ == null)
					cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
				return cb_writeTo_Ljava_io_OutputStream_;
			}

			static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Algorithmia.Client.HttpEntity.InputStreamEntity __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity.InputStreamEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WriteTo (p0);
			}
#pragma warning restore 0169

			static IntPtr id_writeTo_Ljava_io_OutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.InputStreamEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
			public override unsafe void WriteTo (global::System.IO.Stream p0)
			{
				if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTo_Ljava_io_OutputStream_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Ljava/io/OutputStream;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.StringEntity']"
		[global::Android.Runtime.Register ("com/algorithmia/client/HttpEntity$StringEntity", DoNotGenerateAcw=true)]
		public partial class StringEntity : global::Com.Algorithmia.Client.HttpEntity {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/client/HttpEntity$StringEntity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StringEntity); }
			}

			protected StringEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.StringEntity']/constructor[@name='HttpEntity.StringEntity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpContentType']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V", "")]
			public unsafe StringEntity (string p0, global::Com.Algorithmia.Client.HttpContentType p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (StringEntity)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
			static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
			{
				if (cb_writeTo_Ljava_io_OutputStream_ == null)
					cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
				return cb_writeTo_Ljava_io_OutputStream_;
			}

			static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Algorithmia.Client.HttpEntity.StringEntity __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity.StringEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WriteTo (p0);
			}
#pragma warning restore 0169

			static IntPtr id_writeTo_Ljava_io_OutputStream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity.StringEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
			public override unsafe void WriteTo (global::System.IO.Stream p0)
			{
				if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTo_Ljava_io_OutputStream_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Ljava/io/OutputStream;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/client/HttpEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpEntity); }
		}

		protected HttpEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity']/constructor[@name='HttpEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpEntity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpEntity)) {
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Client.HttpEntity __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe global::Com.Algorithmia.Client.HttpContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/algorithmia/client/HttpContentType;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lcom/algorithmia/client/HttpContentType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Lcom/algorithmia/client/HttpContentType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_ == null)
				cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
			return cb_writeTo_Ljava_io_OutputStream_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Client.HttpEntity __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public abstract void WriteTo (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/algorithmia/client/HttpEntity", DoNotGenerateAcw=true)]
	internal partial class HttpEntityInvoker : HttpEntity {

		public HttpEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpEntityInvoker); }
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.client']/class[@name='HttpEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public override unsafe void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTo_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
