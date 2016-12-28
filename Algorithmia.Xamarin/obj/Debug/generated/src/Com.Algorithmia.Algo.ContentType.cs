using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/ContentType", DoNotGenerateAcw=true)]
	public sealed partial class ContentType : global::Java.Lang.Enum {


		static IntPtr Binary_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/field[@name='Binary']"
		[Register ("Binary")]
		public static global::Com.Algorithmia.Algo.ContentType Binary {
			get {
				if (Binary_jfieldId == IntPtr.Zero)
					Binary_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Binary", "Lcom/algorithmia/algo/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Binary_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Json_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/field[@name='Json']"
		[Register ("Json")]
		public static global::Com.Algorithmia.Algo.ContentType Json {
			get {
				if (Json_jfieldId == IntPtr.Zero)
					Json_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Json", "Lcom/algorithmia/algo/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Json_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Text_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/field[@name='Text']"
		[Register ("Text")]
		public static global::Com.Algorithmia.Algo.ContentType Text {
			get {
				if (Text_jfieldId == IntPtr.Zero)
					Text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Text", "Lcom/algorithmia/algo/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Text_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Void_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/field[@name='Void']"
		[Register ("Void")]
		public static global::Com.Algorithmia.Algo.ContentType Void {
			get {
				if (Void_jfieldId == IntPtr.Zero)
					Void_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Void", "Lcom/algorithmia/algo/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Void_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/field[@name='name']"
		[Register ("name")]
		public string Name {
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
				return JNIEnv.FindClass ("com/algorithmia/algo/ContentType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentType); }
		}

		internal ContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/algorithmia/algo/ContentType;", "")]
		public static unsafe global::Com.Algorithmia.Algo.ContentType FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lcom/algorithmia/algo/ContentType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Algo.ContentType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/ContentType;", "")]
		public static unsafe global::Com.Algorithmia.Algo.ContentType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/algorithmia/algo/ContentType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Algorithmia.Algo.ContentType __ret = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.ContentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='ContentType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/algorithmia/algo/ContentType;", "")]
		public static unsafe global::Com.Algorithmia.Algo.ContentType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/algorithmia/algo/ContentType;");
			try {
				return (global::Com.Algorithmia.Algo.ContentType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Algorithmia.Algo.ContentType));
			} finally {
			}
		}

	}
}
