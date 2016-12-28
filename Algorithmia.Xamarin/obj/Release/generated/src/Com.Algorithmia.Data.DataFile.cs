using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']"
	[global::Android.Runtime.Register ("com/algorithmia/data/DataFile", DoNotGenerateAcw=true)]
	public partial class DataFile : global::Com.Algorithmia.Data.DataObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/data/DataFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataFile); }
		}

		protected DataFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/constructor[@name='DataFile' and count(parameter)=2 and parameter[1][@type='com.algorithmia.client.HttpClient'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;)V", "")]
		public unsafe DataFile (global::Com.Algorithmia.Client.HttpClient p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DataFile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getFile;
#pragma warning disable 0169
		static Delegate GetGetFileHandler ()
		{
			if (cb_getFile == null)
				cb_getFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFile);
			return cb_getFile;
		}

		static IntPtr n_GetFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.File);
		}
#pragma warning restore 0169

		static IntPtr id_getFile;
		public virtual unsafe global::Java.IO.File File {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='getFile' and count(parameter)=0]"
			[Register ("getFile", "()Ljava/io/File;", "GetGetFileHandler")]
			get {
				if (id_getFile == IntPtr.Zero)
					id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getString;
#pragma warning disable 0169
		static Delegate GetGetStringHandler ()
		{
			if (cb_getString == null)
				cb_getString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetString);
			return cb_getString;
		}

		static IntPtr n_GetString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.String);
		}
#pragma warning restore 0169

		static IntPtr id_getString;
		public virtual unsafe string String {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='getString' and count(parameter)=0]"
			[Register ("getString", "()Ljava/lang/String;", "GetGetStringHandler")]
			get {
				if (id_getString == IntPtr.Zero)
					id_getString = JNIEnv.GetMethodID (class_ref, "getString", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static Delegate cb_exists;
#pragma warning disable 0169
		static Delegate GetExistsHandler ()
		{
			if (cb_exists == null)
				cb_exists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Exists);
			return cb_exists;
		}

		static bool n_Exists (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		static IntPtr id_exists;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public override unsafe bool Exists ()
		{
			if (id_exists == IntPtr.Zero)
				id_exists = JNIEnv.GetMethodID (class_ref, "exists", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_exists);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exists", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual unsafe byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getString_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_getString_Ljava_nio_charset_Charset_ == null)
				cb_getString_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_nio_charset_Charset_);
			return cb_getString_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_GetString_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("getString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetGetString_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string GetString (global::Java.Nio.Charset.Charset p0)
		{
			if (id_getString_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_getString_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_put_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_arrayBHandler ()
		{
			if (cb_put_arrayB == null)
				cb_put_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_arrayB);
			return cb_put_arrayB;
		}

		static void n_Put_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Put (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='put' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("put", "([B)V", "GetPut_arrayBHandler")]
		public virtual unsafe void Put (byte[] p0)
		{
			if (id_put_arrayB == IntPtr.Zero)
				id_put_arrayB = JNIEnv.GetMethodID (class_ref, "put", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_put_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_File_Handler ()
		{
			if (cb_put_Ljava_io_File_ == null)
				cb_put_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_io_File_);
			return cb_put_Ljava_io_File_;
		}

		static void n_Put_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("put", "(Ljava/io/File;)V", "GetPut_Ljava_io_File_Handler")]
		public virtual unsafe void Put (global::Java.IO.File p0)
		{
			if (id_put_Ljava_io_File_ == IntPtr.Zero)
				id_put_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_io_InputStream_Handler ()
		{
			if (cb_put_Ljava_io_InputStream_ == null)
				cb_put_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_io_InputStream_);
			return cb_put_Ljava_io_InputStream_;
		}

		static void n_Put_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("put", "(Ljava/io/InputStream;)V", "GetPut_Ljava_io_InputStream_Handler")]
		public virtual unsafe void Put (global::System.IO.Stream p0)
		{
			if (id_put_Ljava_io_InputStream_ == IntPtr.Zero)
				id_put_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string p0)
		{
			if (id_put_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ == null)
				cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_);
			return cb_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_;
		}

		static void n_Put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Algorithmia.Data.DataFile __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Client.HttpContentType p1 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpContentType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataFile']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.algorithmia.client.HttpContentType']]"
		[Register ("put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V", "GetPut_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_Handler")]
		public virtual unsafe void Put (string p0, global::Com.Algorithmia.Client.HttpContentType p1)
		{
			if (id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lcom_algorithmia_client_HttpContentType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Lcom/algorithmia/client/HttpContentType;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
