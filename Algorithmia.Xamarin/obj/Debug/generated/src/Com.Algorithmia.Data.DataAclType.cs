using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']"
	[global::Android.Runtime.Register ("com/algorithmia/data/DataAclType", DoNotGenerateAcw=true)]
	public partial class DataAclType : global::Java.Lang.Object {


		static IntPtr MY_ALGOS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/field[@name='MY_ALGOS']"
		[Register ("MY_ALGOS")]
		public static global::Com.Algorithmia.Data.DataAclType MyAlgos {
			get {
				if (MY_ALGOS_jfieldId == IntPtr.Zero)
					MY_ALGOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MY_ALGOS", "Lcom/algorithmia/data/DataAclType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MY_ALGOS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MY_ALGOS_jfieldId == IntPtr.Zero)
					MY_ALGOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MY_ALGOS", "Lcom/algorithmia/data/DataAclType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, MY_ALGOS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/field[@name='MY_ALGOS_PERMISSIONS']"
		[Register ("MY_ALGOS_PERMISSIONS")]
		public const string MyAlgosPermissions = (string) "algo://.my/*";

		static IntPtr PRIVATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/field[@name='PRIVATE']"
		[Register ("PRIVATE")]
		public static global::Com.Algorithmia.Data.DataAclType Private {
			get {
				if (PRIVATE_jfieldId == IntPtr.Zero)
					PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/algorithmia/data/DataAclType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PRIVATE_jfieldId == IntPtr.Zero)
					PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/algorithmia/data/DataAclType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PRIVATE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PUBLIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/field[@name='PUBLIC']"
		[Register ("PUBLIC")]
		public static global::Com.Algorithmia.Data.DataAclType Public {
			get {
				if (PUBLIC_jfieldId == IntPtr.Zero)
					PUBLIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC", "Lcom/algorithmia/data/DataAclType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PUBLIC_jfieldId == IntPtr.Zero)
					PUBLIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC", "Lcom/algorithmia/data/DataAclType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PUBLIC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/field[@name='PUBLIC_PERMISSIONS']"
		[Register ("PUBLIC_PERMISSIONS")]
		public const string PublicPermissions = (string) "user://*";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/data/DataAclType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataAclType); }
		}

		protected DataAclType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/constructor[@name='DataAclType' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe DataAclType (global::System.Collections.Generic.IList<string> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (DataAclType)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAclStrings;
#pragma warning disable 0169
		static Delegate GetGetAclStringsHandler ()
		{
			if (cb_getAclStrings == null)
				cb_getAclStrings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAclStrings);
			return cb_getAclStrings;
		}

		static IntPtr n_GetAclStrings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.DataAclType __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AclStrings);
		}
#pragma warning restore 0169

		static IntPtr id_getAclStrings;
		public virtual unsafe global::System.Collections.Generic.IList<string> AclStrings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/method[@name='getAclStrings' and count(parameter)=0]"
			[Register ("getAclStrings", "()Ljava/util/List;", "GetGetAclStringsHandler")]
			get {
				if (id_getAclStrings == IntPtr.Zero)
					id_getAclStrings = JNIEnv.GetMethodID (class_ref, "getAclStrings", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAclStrings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAclStrings", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromAclStrings_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='DataAclType']/method[@name='fromAclStrings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("fromAclStrings", "(Ljava/util/List;)Lcom/algorithmia/data/DataAclType;", "")]
		public static unsafe global::Com.Algorithmia.Data.DataAclType FromAclStrings (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_fromAclStrings_Ljava_util_List_ == IntPtr.Zero)
				id_fromAclStrings_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "fromAclStrings", "(Ljava/util/List;)Lcom/algorithmia/data/DataAclType;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Data.DataAclType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.DataAclType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAclStrings_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
