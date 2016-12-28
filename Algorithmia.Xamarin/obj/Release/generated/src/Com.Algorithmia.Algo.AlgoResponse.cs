using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']"
	[global::Android.Runtime.Register ("com/algorithmia/algo/AlgoResponse", DoNotGenerateAcw=true)]
	public abstract partial class AlgoResponse : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/algorithmia/algo/AlgoResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgoResponse); }
		}

		protected AlgoResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/constructor[@name='AlgoResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlgoResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AlgoResponse)) {
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

		static Delegate cb_isFailure;
#pragma warning disable 0169
		static Delegate GetIsFailureHandler ()
		{
			if (cb_isFailure == null)
				cb_isFailure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFailure);
			return cb_isFailure;
		}

		static bool n_IsFailure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFailure;
		}
#pragma warning restore 0169

		public abstract bool IsFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='isFailure' and count(parameter)=0]"
			[Register ("isFailure", "()Z", "GetIsFailureHandler")] get;
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		public abstract bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")] get;
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		public abstract global::Com.Algorithmia.Algo.Metadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/algorithmia/algo/Metadata;", "GetGetMetadataHandler")] get;
		}

		static Delegate cb_getRawOutput;
#pragma warning disable 0169
		static Delegate GetGetRawOutputHandler ()
		{
			if (cb_getRawOutput == null)
				cb_getRawOutput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawOutput);
			return cb_getRawOutput;
		}

		static IntPtr n_GetRawOutput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RawOutput);
		}
#pragma warning restore 0169

		public abstract string RawOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='getRawOutput' and count(parameter)=0]"
			[Register ("getRawOutput", "()Ljava/lang/String;", "GetGetRawOutputHandler")] get;
		}

		static Delegate cb_as_Lcom_algorithmia_TypeToken_;
#pragma warning disable 0169
		static Delegate GetAs_Lcom_algorithmia_TypeToken_Handler ()
		{
			if (cb_as_Lcom_algorithmia_TypeToken_ == null)
				cb_as_Lcom_algorithmia_TypeToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_As_Lcom_algorithmia_TypeToken_);
			return cb_as_Lcom_algorithmia_TypeToken_;
		}

		static IntPtr n_As_Lcom_algorithmia_TypeToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Algorithmia.TypeToken p0 = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.TypeToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.As (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_as_Lcom_algorithmia_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='as' and count(parameter)=1 and parameter[1][@type='com.algorithmia.TypeToken']]"
		[Register ("as", "(Lcom/algorithmia/TypeToken;)Ljava/lang/Object;", "GetAs_Lcom_algorithmia_TypeToken_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object As (global::Com.Algorithmia.TypeToken p0)
		{
			if (id_as_Lcom_algorithmia_TypeToken_ == IntPtr.Zero)
				id_as_Lcom_algorithmia_TypeToken_ = JNIEnv.GetMethodID (class_ref, "as", "(Lcom/algorithmia/TypeToken;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Lcom_algorithmia_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "as", "(Lcom/algorithmia/TypeToken;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_as_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetAs_Ljava_lang_Class_Handler ()
		{
			if (cb_as_Ljava_lang_Class_ == null)
				cb_as_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_As_Ljava_lang_Class_);
			return cb_as_Ljava_lang_Class_;
		}

		static IntPtr n_As_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.As (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("as", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetAs_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected abstract global::Java.Lang.Object As (global::Java.Lang.Class p0);

		static Delegate cb_as_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		static Delegate GetAs_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_as_Ljava_lang_reflect_Type_ == null)
				cb_as_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_As_Ljava_lang_reflect_Type_);
			return cb_as_Ljava_lang_reflect_Type_;
		}

		static IntPtr n_As_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p0 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.As (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("as", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;", "GetAs_Ljava_lang_reflect_Type_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected abstract global::Java.Lang.Object As (global::Java.Lang.Reflect.IType p0);

		static Delegate cb_asJsonString;
#pragma warning disable 0169
		static Delegate GetAsJsonStringHandler ()
		{
			if (cb_asJsonString == null)
				cb_asJsonString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsJsonString);
			return cb_asJsonString;
		}

		static IntPtr n_AsJsonString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsJsonString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='asJsonString' and count(parameter)=0]"
		[Register ("asJsonString", "()Ljava/lang/String;", "GetAsJsonStringHandler")]
		public abstract string AsJsonString ();

		static Delegate cb_asString;
#pragma warning disable 0169
		static Delegate GetAsStringHandler ()
		{
			if (cb_asString == null)
				cb_asString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsString);
			return cb_asString;
		}

		static IntPtr n_AsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Algo.AlgoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.AlgoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler")]
		public abstract string AsString ();

	}

	[global::Android.Runtime.Register ("com/algorithmia/algo/AlgoResponse", DoNotGenerateAcw=true)]
	internal partial class AlgoResponseInvoker : AlgoResponse {

		public AlgoResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgoResponseInvoker); }
		}

		static IntPtr id_isFailure;
		public override unsafe bool IsFailure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='isFailure' and count(parameter)=0]"
			[Register ("isFailure", "()Z", "GetIsFailureHandler")]
			get {
				if (id_isFailure == IntPtr.Zero)
					id_isFailure = JNIEnv.GetMethodID (class_ref, "isFailure", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFailure);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccess;
		public override unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccess);
				} finally {
				}
			}
		}

		static IntPtr id_getMetadata;
		public override unsafe global::Com.Algorithmia.Algo.Metadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/algorithmia/algo/Metadata;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lcom/algorithmia/algo/Metadata;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Algo.Metadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRawOutput;
		public override unsafe string RawOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='getRawOutput' and count(parameter)=0]"
			[Register ("getRawOutput", "()Ljava/lang/String;", "GetGetRawOutputHandler")]
			get {
				if (id_getRawOutput == IntPtr.Zero)
					id_getRawOutput = JNIEnv.GetMethodID (class_ref, "getRawOutput", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawOutput), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_as_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("as", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetAs_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected override unsafe global::Java.Lang.Object As (global::Java.Lang.Class p0)
		{
			if (id_as_Ljava_lang_Class_ == IntPtr.Zero)
				id_as_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "as", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_as_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='as' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("as", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;", "GetAs_Ljava_lang_reflect_Type_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		protected override unsafe global::Java.Lang.Object As (global::Java.Lang.Reflect.IType p0)
		{
			if (id_as_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_as_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "as", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_as_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_asJsonString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='asJsonString' and count(parameter)=0]"
		[Register ("asJsonString", "()Ljava/lang/String;", "GetAsJsonStringHandler")]
		public override unsafe string AsJsonString ()
		{
			if (id_asJsonString == IntPtr.Zero)
				id_asJsonString = JNIEnv.GetMethodID (class_ref, "asJsonString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asJsonString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.algo']/class[@name='AlgoResponse']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler")]
		public override unsafe string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
