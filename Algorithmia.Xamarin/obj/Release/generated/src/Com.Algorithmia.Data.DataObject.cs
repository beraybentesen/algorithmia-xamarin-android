using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']"
	[global::Android.Runtime.Register ("com/algorithmia/data/DataObject", DoNotGenerateAcw=true)]
	public abstract partial class DataObject : global::Java.Lang.Object {


		static IntPtr client_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/field[@name='client']"
		[Register ("client")]
		protected global::Com.Algorithmia.Client.HttpClient Client {
			get {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lcom/algorithmia/client/HttpClient;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, client_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Client.HttpClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (client_jfieldId == IntPtr.Zero)
					client_jfieldId = JNIEnv.GetFieldID (class_ref, "client", "Lcom/algorithmia/client/HttpClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, client_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr dataType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/field[@name='dataType']"
		[Register ("dataType")]
		protected global::Com.Algorithmia.Data.DataObject.DataObjectType DataType {
			get {
				if (dataType_jfieldId == IntPtr.Zero)
					dataType_jfieldId = JNIEnv.GetFieldID (class_ref, "dataType", "Lcom/algorithmia/data/DataObject$DataObjectType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dataType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dataType_jfieldId == IntPtr.Zero)
					dataType_jfieldId = JNIEnv.GetFieldID (class_ref, "dataType", "Lcom/algorithmia/data/DataObject$DataObjectType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/field[@name='path']"
		[Register ("path")]
		public string Path {
			get {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, path_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, path_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject.DataObjectType']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataObject$DataObjectType", DoNotGenerateAcw=true)]
		public sealed partial class DataObjectType : global::Java.Lang.Enum {


			static IntPtr DIRECTORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject.DataObjectType']/field[@name='DIRECTORY']"
			[Register ("DIRECTORY")]
			public static global::Com.Algorithmia.Data.DataObject.DataObjectType Directory {
				get {
					if (DIRECTORY_jfieldId == IntPtr.Zero)
						DIRECTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIRECTORY", "Lcom/algorithmia/data/DataObject$DataObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIRECTORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject.DataObjectType']/field[@name='FILE']"
			[Register ("FILE")]
			public static global::Com.Algorithmia.Data.DataObject.DataObjectType File {
				get {
					if (FILE_jfieldId == IntPtr.Zero)
						FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE", "Lcom/algorithmia/data/DataObject$DataObjectType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/data/DataObject$DataObjectType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DataObjectType); }
			}

			internal DataObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject.DataObjectType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/algorithmia/data/DataObject$DataObjectType;", "")]
			public static unsafe global::Com.Algorithmia.Data.DataObject.DataObjectType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/algorithmia/data/DataObject$DataObjectType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Algorithmia.Data.DataObject.DataObjectType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject.DataObjectType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/algorithmia/data/DataObject$DataObjectType;", "")]
			public static unsafe global::Com.Algorithmia.Data.DataObject.DataObjectType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/algorithmia/data/DataObject$DataObjectType;");
				try {
					return (global::Com.Algorithmia.Data.DataObject.DataObjectType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Algorithmia.Data.DataObject.DataObjectType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/data/DataObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataObject); }
		}

		protected DataObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_Lcom_algorithmia_data_DataObject_DataObjectType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/constructor[@name='DataObject' and count(parameter)=3 and parameter[1][@type='com.algorithmia.client.HttpClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.algorithmia.data.DataObject.DataObjectType']]"
		[Register (".ctor", "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;Lcom/algorithmia/data/DataObject$DataObjectType;)V", "")]
		public unsafe DataObject (global::Com.Algorithmia.Client.HttpClient p0, string p1, global::Com.Algorithmia.Data.DataObject.DataObjectType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DataObject)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;Lcom/algorithmia/data/DataObject$DataObjectType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;Lcom/algorithmia/data/DataObject$DataObjectType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_Lcom_algorithmia_data_DataObject_DataObjectType_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_Lcom_algorithmia_data_DataObject_DataObjectType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;Lcom/algorithmia/data/DataObject$DataObjectType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_Lcom_algorithmia_data_DataObject_DataObjectType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_Lcom_algorithmia_data_DataObject_DataObjectType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isDirectory;
#pragma warning disable 0169
		static Delegate GetIsDirectoryHandler ()
		{
			if (cb_isDirectory == null)
				cb_isDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDirectory);
			return cb_isDirectory;
		}

		static bool n_IsDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDirectory;
		}
#pragma warning restore 0169

		static IntPtr id_isDirectory;
		public virtual unsafe bool IsDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='isDirectory' and count(parameter)=0]"
			[Register ("isDirectory", "()Z", "GetIsDirectoryHandler")]
			get {
				if (id_isDirectory == IntPtr.Zero)
					id_isDirectory = JNIEnv.GetMethodID (class_ref, "isDirectory", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDirectory);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDirectory", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFile;
#pragma warning disable 0169
		static Delegate GetIsFileHandler ()
		{
			if (cb_isFile == null)
				cb_isFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFile);
			return cb_isFile;
		}

		static bool n_IsFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFile;
		}
#pragma warning restore 0169

		static IntPtr id_isFile;
		public virtual unsafe bool IsFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='isFile' and count(parameter)=0]"
			[Register ("isFile", "()Z", "GetIsFileHandler")]
			get {
				if (id_isFile == IntPtr.Zero)
					id_isFile = JNIEnv.GetMethodID (class_ref, "isFile", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFile);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFile", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParent;
#pragma warning disable 0169
		static Delegate GetGetParentHandler ()
		{
			if (cb_getParent == null)
				cb_getParent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParent);
			return cb_getParent;
		}

		static IntPtr n_GetParent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parent);
		}
#pragma warning restore 0169

		static IntPtr id_getParent;
		public virtual unsafe global::Com.Algorithmia.Data.DataDirectory Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lcom/algorithmia/data/DataDirectory;", "GetGetParentHandler")]
			get {
				if (id_getParent == IntPtr.Zero)
					id_getParent = JNIEnv.GetMethodID (class_ref, "getParent", "()Lcom/algorithmia/data/DataDirectory;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParent", "()Lcom/algorithmia/data/DataDirectory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Algorithmia.Data.DataObject.DataObjectType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/algorithmia/data/DataObject$DataObjectType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/algorithmia/data/DataObject$DataObjectType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject.DataObjectType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/algorithmia/data/DataObject$DataObjectType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Algorithmia.Data.DataObject __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public abstract bool Exists ();

	}

	[global::Android.Runtime.Register ("com/algorithmia/data/DataObject", DoNotGenerateAcw=true)]
	internal partial class DataObjectInvoker : DataObject {

		public DataObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataObjectInvoker); }
		}

		static IntPtr id_exists;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataObject']/method[@name='exists' and count(parameter)=0]"
		[Register ("exists", "()Z", "GetExistsHandler")]
		public override unsafe bool Exists ()
		{
			if (id_exists == IntPtr.Zero)
				id_exists = JNIEnv.GetMethodID (class_ref, "exists", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_exists);
			} finally {
			}
		}

	}

}
