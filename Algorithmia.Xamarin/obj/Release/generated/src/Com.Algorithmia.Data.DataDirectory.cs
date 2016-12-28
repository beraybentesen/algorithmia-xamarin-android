using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']"
	[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory", DoNotGenerateAcw=true)]
	public partial class DataDirectory : global::Com.Algorithmia.Data.DataObject {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.CreateDirectoryRequest']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory$CreateDirectoryRequest", DoNotGenerateAcw=true)]
		public partial class CreateDirectoryRequest : global::Java.Lang.Object {

			protected CreateDirectoryRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory$DirectoryListResponse", DoNotGenerateAcw=true)]
		protected internal partial class DirectoryListResponse : global::Java.Lang.Object {


			static IntPtr acl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']/field[@name='acl']"
			[Register ("acl")]
			protected global::System.Collections.IDictionary Acl {
				get {
					if (acl_jfieldId == IntPtr.Zero)
						acl_jfieldId = JNIEnv.GetFieldID (class_ref, "acl", "Ljava/util/Map;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, acl_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (acl_jfieldId == IntPtr.Zero)
						acl_jfieldId = JNIEnv.GetFieldID (class_ref, "acl", "Ljava/util/Map;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, acl_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr files_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']/field[@name='files']"
			[Register ("files")]
			protected global::System.Collections.IList Files {
				get {
					if (files_jfieldId == IntPtr.Zero)
						files_jfieldId = JNIEnv.GetFieldID (class_ref, "files", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, files_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (files_jfieldId == IntPtr.Zero)
						files_jfieldId = JNIEnv.GetFieldID (class_ref, "files", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, files_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr folders_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']/field[@name='folders']"
			[Register ("folders")]
			protected global::System.Collections.IList Folders {
				get {
					if (folders_jfieldId == IntPtr.Zero)
						folders_jfieldId = JNIEnv.GetFieldID (class_ref, "folders", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, folders_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (folders_jfieldId == IntPtr.Zero)
						folders_jfieldId = JNIEnv.GetFieldID (class_ref, "folders", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, folders_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr marker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']/field[@name='marker']"
			[Register ("marker")]
			protected string Marker {
				get {
					if (marker_jfieldId == IntPtr.Zero)
						marker_jfieldId = JNIEnv.GetFieldID (class_ref, "marker", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, marker_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (marker_jfieldId == IntPtr.Zero)
						marker_jfieldId = JNIEnv.GetFieldID (class_ref, "marker", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, marker_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/data/DataDirectory$DirectoryListResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DirectoryListResponse); }
			}

			protected DirectoryListResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_util_Map_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryListResponse']/constructor[@name='DataDirectory.DirectoryListResponse' and count(parameter)=5 and parameter[1][@type='com.algorithmia.data.DataDirectory'] and parameter[2][@type='java.util.List&lt;com.algorithmia.data.DataDirectory.FileMetadata&gt;'] and parameter[3][@type='java.util.List&lt;com.algorithmia.data.DataDirectory.DirectoryMetadata&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
			[Register (".ctor", "(Lcom/algorithmia/data/DataDirectory;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", "")]
			protected unsafe DirectoryListResponse (global::Com.Algorithmia.Data.DataDirectory __self, global::System.Collections.Generic.IList<global::Com.Algorithmia.Data.DataDirectory.FileMetadata> p0, global::System.Collections.Generic.IList<global::Com.Algorithmia.Data.DataDirectory.DirectoryMetadata> p1, string p2, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Algorithmia.Data.DataDirectory.FileMetadata>.ToLocalJniHandle (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Algorithmia.Data.DataDirectory.DirectoryMetadata>.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p3);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p0);
					__args [2] = new JValue (native_p1);
					__args [3] = new JValue (native_p2);
					__args [4] = new JValue (native_p3);
					if (GetType () != typeof (DirectoryListResponse)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V", __args);
						return;
					}

					if (id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
						id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/data/DataDirectory;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/util/Map;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_util_Map_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_util_Map_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryMetadata']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory$DirectoryMetadata", DoNotGenerateAcw=true)]
		protected internal partial class DirectoryMetadata : global::Java.Lang.Object {


			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryMetadata']/field[@name='name']"
			[Register ("name")]
			protected string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/data/DataDirectory$DirectoryMetadata", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DirectoryMetadata); }
			}

			protected DirectoryMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.DirectoryMetadata']/constructor[@name='DataDirectory.DirectoryMetadata' and count(parameter)=2 and parameter[1][@type='com.algorithmia.data.DataDirectory'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/algorithmia/data/DataDirectory;Ljava/lang/String;)V", "")]
			protected unsafe DirectoryMetadata (global::Com.Algorithmia.Data.DataDirectory __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (DirectoryMetadata)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/data/DataDirectory;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.FileMetadata']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory$FileMetadata", DoNotGenerateAcw=true)]
		protected internal partial class FileMetadata : global::Java.Lang.Object {


			static IntPtr filename_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.FileMetadata']/field[@name='filename']"
			[Register ("filename")]
			protected string Filename {
				get {
					if (filename_jfieldId == IntPtr.Zero)
						filename_jfieldId = JNIEnv.GetFieldID (class_ref, "filename", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, filename_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (filename_jfieldId == IntPtr.Zero)
						filename_jfieldId = JNIEnv.GetFieldID (class_ref, "filename", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, filename_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/algorithmia/data/DataDirectory$FileMetadata", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FileMetadata); }
			}

			protected FileMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.FileMetadata']/constructor[@name='DataDirectory.FileMetadata' and count(parameter)=2 and parameter[1][@type='com.algorithmia.data.DataDirectory'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/algorithmia/data/DataDirectory;Ljava/lang/String;)V", "")]
			protected unsafe FileMetadata (global::Com.Algorithmia.Data.DataDirectory __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (FileMetadata)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/data/DataDirectory;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_data_DataDirectory_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory.UpdateDirectoryRequest']"
		[global::Android.Runtime.Register ("com/algorithmia/data/DataDirectory$UpdateDirectoryRequest", DoNotGenerateAcw=true)]
		public partial class UpdateDirectoryRequest : global::Java.Lang.Object {

			protected UpdateDirectoryRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/data/DataDirectory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataDirectory); }
		}

		protected DataDirectory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_client_HttpClient_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/constructor[@name='DataDirectory' and count(parameter)=2 and parameter[1][@type='com.algorithmia.client.HttpClient'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/algorithmia/client/HttpClient;Ljava/lang/String;)V", "")]
		public unsafe DataDirectory (global::Com.Algorithmia.Client.HttpClient p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DataDirectory)) {
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

		static Delegate cb_getPermissions;
#pragma warning disable 0169
		static Delegate GetGetPermissionsHandler ()
		{
			if (cb_getPermissions == null)
				cb_getPermissions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPermissions);
			return cb_getPermissions;
		}

		static IntPtr n_GetPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Permissions);
		}
#pragma warning restore 0169

		static IntPtr id_getPermissions;
		public virtual unsafe global::Com.Algorithmia.Data.DataAcl Permissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='getPermissions' and count(parameter)=0]"
			[Register ("getPermissions", "()Lcom/algorithmia/data/DataAcl;", "GetGetPermissionsHandler")]
			get {
				if (id_getPermissions == IntPtr.Zero)
					id_getPermissions = JNIEnv.GetMethodID (class_ref, "getPermissions", "()Lcom/algorithmia/data/DataAcl;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPermissions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermissions", "()Lcom/algorithmia/data/DataAcl;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static void n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Create ();
		}
#pragma warning restore 0169

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "GetCreateHandler")]
		public virtual unsafe void Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_create);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()V"));
			} finally {
			}
		}

		static Delegate cb_create_Lcom_algorithmia_data_DataAcl_;
#pragma warning disable 0169
		static Delegate GetCreate_Lcom_algorithmia_data_DataAcl_Handler ()
		{
			if (cb_create_Lcom_algorithmia_data_DataAcl_ == null)
				cb_create_Lcom_algorithmia_data_DataAcl_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Create_Lcom_algorithmia_data_DataAcl_);
			return cb_create_Lcom_algorithmia_data_DataAcl_;
		}

		static void n_Create_Lcom_algorithmia_data_DataAcl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Data.DataAcl p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Create (p0);
		}
#pragma warning restore 0169

		static IntPtr id_create_Lcom_algorithmia_data_DataAcl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.algorithmia.data.DataAcl']]"
		[Register ("create", "(Lcom/algorithmia/data/DataAcl;)V", "GetCreate_Lcom_algorithmia_data_DataAcl_Handler")]
		public virtual unsafe void Create (global::Com.Algorithmia.Data.DataAcl p0)
		{
			if (id_create_Lcom_algorithmia_data_DataAcl_ == IntPtr.Zero)
				id_create_Lcom_algorithmia_data_DataAcl_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/algorithmia/data/DataAcl;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_algorithmia_data_DataAcl_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Lcom/algorithmia/data/DataAcl;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_delete_Z;
#pragma warning disable 0169
		static Delegate GetDelete_ZHandler ()
		{
			if (cb_delete_Z == null)
				cb_delete_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Delete_Z);
			return cb_delete_Z;
		}

		static void n_Delete_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("delete", "(Z)V", "GetDelete_ZHandler")]
		public virtual unsafe void Delete (bool p0)
		{
			if (id_delete_Z == IntPtr.Zero)
				id_delete_Z = JNIEnv.GetMethodID (class_ref, "delete", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_dirs;
#pragma warning disable 0169
		static Delegate GetDirsHandler ()
		{
			if (cb_dirs == null)
				cb_dirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Dirs);
			return cb_dirs;
		}

		static IntPtr n_Dirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dirs ());
		}
#pragma warning restore 0169

		static IntPtr id_dirs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='dirs' and count(parameter)=0]"
		[Register ("dirs", "()Ljava/lang/Iterable;", "GetDirsHandler")]
		public virtual unsafe global::Java.Lang.IIterable Dirs ()
		{
			if (id_dirs == IntPtr.Zero)
				id_dirs = JNIEnv.GetMethodID (class_ref, "dirs", "()Ljava/lang/Iterable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dirs), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dirs", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Exists ();
		}
#pragma warning restore 0169

		static IntPtr id_exists;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='exists' and count(parameter)=0]"
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

		static Delegate cb_file_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFile_Ljava_lang_String_Handler ()
		{
			if (cb_file_Ljava_lang_String_ == null)
				cb_file_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_File_Ljava_lang_String_);
			return cb_file_Ljava_lang_String_;
		}

		static IntPtr n_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.File (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_file_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='file' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("file", "(Ljava/lang/String;)Lcom/algorithmia/data/DataFile;", "GetFile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Algorithmia.Data.DataFile File (string p0)
		{
			if (id_file_Ljava_lang_String_ == IntPtr.Zero)
				id_file_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "file", "(Ljava/lang/String;)Lcom/algorithmia/data/DataFile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Algorithmia.Data.DataFile __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_file_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "file", "(Ljava/lang/String;)Lcom/algorithmia/data/DataFile;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_files;
#pragma warning disable 0169
		static Delegate GetFilesHandler ()
		{
			if (cb_files == null)
				cb_files = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Files);
			return cb_files;
		}

		static IntPtr n_Files (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Files ());
		}
#pragma warning restore 0169

		static IntPtr id_files;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='files' and count(parameter)=0]"
		[Register ("files", "()Ljava/lang/Iterable;", "GetFilesHandler")]
		public virtual unsafe global::Java.Lang.IIterable Files ()
		{
			if (id_files == IntPtr.Zero)
				id_files = JNIEnv.GetMethodID (class_ref, "files", "()Ljava/lang/Iterable;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_files), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "files", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPage_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetPage_Ljava_lang_String_ZHandler ()
		{
			if (cb_getPage_Ljava_lang_String_Z == null)
				cb_getPage_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetPage_Ljava_lang_String_Z);
			return cb_getPage_Ljava_lang_String_Z;
		}

		static IntPtr n_GetPage_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPage_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='getPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getPage", "(Ljava/lang/String;Z)Lcom/algorithmia/data/DataDirectory$DirectoryListResponse;", "GetGetPage_Ljava_lang_String_ZHandler")]
		protected virtual unsafe global::Com.Algorithmia.Data.DataDirectory.DirectoryListResponse GetPage (string p0, bool p1)
		{
			if (id_getPage_Ljava_lang_String_Z == IntPtr.Zero)
				id_getPage_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getPage", "(Ljava/lang/String;Z)Lcom/algorithmia/data/DataDirectory$DirectoryListResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Algorithmia.Data.DataDirectory.DirectoryListResponse __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory.DirectoryListResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPage_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory.DirectoryListResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPage", "(Ljava/lang/String;Z)Lcom/algorithmia/data/DataDirectory$DirectoryListResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetPutFile_Ljava_io_File_Handler ()
		{
			if (cb_putFile_Ljava_io_File_ == null)
				cb_putFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutFile_Ljava_io_File_);
			return cb_putFile_Ljava_io_File_;
		}

		static IntPtr n_PutFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_putFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='putFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("putFile", "(Ljava/io/File;)Lcom/algorithmia/data/DataFile;", "GetPutFile_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Algorithmia.Data.DataFile PutFile (global::Java.IO.File p0)
		{
			if (id_putFile_Ljava_io_File_ == IntPtr.Zero)
				id_putFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "putFile", "(Ljava/io/File;)Lcom/algorithmia/data/DataFile;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Algorithmia.Data.DataFile __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataFile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putFile", "(Ljava/io/File;)Lcom/algorithmia/data/DataFile;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updatePermissions_Lcom_algorithmia_data_DataAcl_;
#pragma warning disable 0169
		static Delegate GetUpdatePermissions_Lcom_algorithmia_data_DataAcl_Handler ()
		{
			if (cb_updatePermissions_Lcom_algorithmia_data_DataAcl_ == null)
				cb_updatePermissions_Lcom_algorithmia_data_DataAcl_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdatePermissions_Lcom_algorithmia_data_DataAcl_);
			return cb_updatePermissions_Lcom_algorithmia_data_DataAcl_;
		}

		static bool n_UpdatePermissions_Lcom_algorithmia_data_DataAcl_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.DataDirectory __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataDirectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.Data.DataAcl p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdatePermissions (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updatePermissions_Lcom_algorithmia_data_DataAcl_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataDirectory']/method[@name='updatePermissions' and count(parameter)=1 and parameter[1][@type='com.algorithmia.data.DataAcl']]"
		[Register ("updatePermissions", "(Lcom/algorithmia/data/DataAcl;)Z", "GetUpdatePermissions_Lcom_algorithmia_data_DataAcl_Handler")]
		public virtual unsafe bool UpdatePermissions (global::Com.Algorithmia.Data.DataAcl p0)
		{
			if (id_updatePermissions_Lcom_algorithmia_data_DataAcl_ == IntPtr.Zero)
				id_updatePermissions_Lcom_algorithmia_data_DataAcl_ = JNIEnv.GetMethodID (class_ref, "updatePermissions", "(Lcom/algorithmia/data/DataAcl;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updatePermissions_Lcom_algorithmia_data_DataAcl_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePermissions", "(Lcom/algorithmia/data/DataAcl;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
