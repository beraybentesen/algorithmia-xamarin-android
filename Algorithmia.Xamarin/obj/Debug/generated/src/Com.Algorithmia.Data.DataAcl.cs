using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']"
	[global::Android.Runtime.Register ("com/algorithmia/data/DataAcl", DoNotGenerateAcw=true)]
	public partial class DataAcl : global::Java.Lang.Object {


		static IntPtr MY_ALGOS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/field[@name='MY_ALGOS']"
		[Register ("MY_ALGOS")]
		public static global::Com.Algorithmia.Data.DataAcl MyAlgos {
			get {
				if (MY_ALGOS_jfieldId == IntPtr.Zero)
					MY_ALGOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MY_ALGOS", "Lcom/algorithmia/data/DataAcl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MY_ALGOS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRIVATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/field[@name='PRIVATE']"
		[Register ("PRIVATE")]
		public static global::Com.Algorithmia.Data.DataAcl Private {
			get {
				if (PRIVATE_jfieldId == IntPtr.Zero)
					PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/algorithmia/data/DataAcl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PUBLIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/field[@name='PUBLIC']"
		[Register ("PUBLIC")]
		public static global::Com.Algorithmia.Data.DataAcl Public {
			get {
				if (PUBLIC_jfieldId == IntPtr.Zero)
					PUBLIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC", "Lcom/algorithmia/data/DataAcl;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr read_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/field[@name='read']"
		[Register ("read")]
		protected global::System.Collections.IList Read {
			get {
				if (read_jfieldId == IntPtr.Zero)
					read_jfieldId = JNIEnv.GetFieldID (class_ref, "read", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, read_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (read_jfieldId == IntPtr.Zero)
					read_jfieldId = JNIEnv.GetFieldID (class_ref, "read", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, read_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/data/DataAcl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataAcl); }
		}

		protected DataAcl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_algorithmia_data_DataAclType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/constructor[@name='DataAcl' and count(parameter)=1 and parameter[1][@type='com.algorithmia.data.DataAclType']]"
		[Register (".ctor", "(Lcom/algorithmia/data/DataAclType;)V", "")]
		public unsafe DataAcl (global::Com.Algorithmia.Data.DataAclType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DataAcl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/algorithmia/data/DataAclType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/algorithmia/data/DataAclType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_algorithmia_data_DataAclType_ == IntPtr.Zero)
					id_ctor_Lcom_algorithmia_data_DataAclType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/algorithmia/data/DataAclType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_algorithmia_data_DataAclType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_algorithmia_data_DataAclType_, __args);
			} finally {
			}
		}

		static Delegate cb_getReadPermissions;
#pragma warning disable 0169
		static Delegate GetGetReadPermissionsHandler ()
		{
			if (cb_getReadPermissions == null)
				cb_getReadPermissions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReadPermissions);
			return cb_getReadPermissions;
		}

		static IntPtr n_GetReadPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataAcl __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadPermissions);
		}
#pragma warning restore 0169

		static IntPtr id_getReadPermissions;
		public virtual unsafe global::Com.Algorithmia.Data.DataAclType ReadPermissions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/method[@name='getReadPermissions' and count(parameter)=0]"
			[Register ("getReadPermissions", "()Lcom/algorithmia/data/DataAclType;", "GetGetReadPermissionsHandler")]
			get {
				if (id_getReadPermissions == IntPtr.Zero)
					id_getReadPermissions = JNIEnv.GetMethodID (class_ref, "getReadPermissions", "()Lcom/algorithmia/data/DataAclType;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReadPermissions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadPermissions", "()Lcom/algorithmia/data/DataAclType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromAclResponse_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAcl']/method[@name='fromAclResponse' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("fromAclResponse", "(Ljava/util/Map;)Lcom/algorithmia/data/DataAcl;", "")]
		public static unsafe global::Com.Algorithmia.Data.DataAcl FromAclResponse (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0)
		{
			if (id_fromAclResponse_Ljava_util_Map_ == IntPtr.Zero)
				id_fromAclResponse_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "fromAclResponse", "(Ljava/util/Map;)Lcom/algorithmia/data/DataAcl;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Data.DataAcl __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAcl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAclResponse_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
