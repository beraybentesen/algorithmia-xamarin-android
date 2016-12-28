using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Algorithmia.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']"
	[global::Android.Runtime.Register ("com/algorithmia/data/AbstractDataIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractDataIterator : global::Java.Lang.Object, global::Java.Util.IIterator {


		static IntPtr marker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/field[@name='marker']"
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
				return JNIEnv.FindClass ("com/algorithmia/data/AbstractDataIterator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataIterator); }
		}

		protected AbstractDataIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.AbstractDataIterator __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.AbstractDataIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		static IntPtr id_hasNext;
		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNext", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_loadNextPage;
#pragma warning disable 0169
		static Delegate GetLoadNextPageHandler ()
		{
			if (cb_loadNextPage == null)
				cb_loadNextPage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadNextPage);
			return cb_loadNextPage;
		}

		static void n_LoadNextPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.AbstractDataIterator __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.AbstractDataIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadNextPage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='loadNextPage' and count(parameter)=0]"
		[Register ("loadNextPage", "()V", "GetLoadNextPageHandler")]
		protected abstract void LoadNextPage ();

		static Delegate cb_newDataObjectInstance_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNewDataObjectInstance_Ljava_lang_String_Handler ()
		{
			if (cb_newDataObjectInstance_Ljava_lang_String_ == null)
				cb_newDataObjectInstance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewDataObjectInstance_Ljava_lang_String_);
			return cb_newDataObjectInstance_Ljava_lang_String_;
		}

		static IntPtr n_NewDataObjectInstance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Algorithmia.Data.AbstractDataIterator __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.AbstractDataIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewDataObjectInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='newDataObjectInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newDataObjectInstance", "(Ljava/lang/String;)Ljava/lang/Object;", "GetNewDataObjectInstance_Ljava_lang_String_Handler")]
		protected abstract global::Java.Lang.Object NewDataObjectInstance (string p0);

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.AbstractDataIterator __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.AbstractDataIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		static IntPtr id_next;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Algorithmia.Data.AbstractDataIterator __this = global::Java.Lang.Object.GetObject<global::Com.Algorithmia.Data.AbstractDataIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()V"));
			} finally {
			}
		}

		static IntPtr id_setChildrenAndMarker_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='setChildrenAndMarker' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("setChildrenAndMarker", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		protected unsafe void SetChildrenAndMarker (global::System.Collections.Generic.IList<string> p0, string p1)
		{
			if (id_setChildrenAndMarker_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_setChildrenAndMarker_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChildrenAndMarker", "(Ljava/util/List;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChildrenAndMarker_Ljava_util_List_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("com/algorithmia/data/AbstractDataIterator", DoNotGenerateAcw=true)]
	internal partial class AbstractDataIteratorInvoker : AbstractDataIterator {

		public AbstractDataIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDataIteratorInvoker); }
		}

		static IntPtr id_loadNextPage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='loadNextPage' and count(parameter)=0]"
		[Register ("loadNextPage", "()V", "GetLoadNextPageHandler")]
		protected override unsafe void LoadNextPage ()
		{
			if (id_loadNextPage == IntPtr.Zero)
				id_loadNextPage = JNIEnv.GetMethodID (class_ref, "loadNextPage", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadNextPage);
			} finally {
			}
		}

		static IntPtr id_newDataObjectInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.algorithmia.data']/class[@name='AbstractDataIterator']/method[@name='newDataObjectInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newDataObjectInstance", "(Ljava/lang/String;)Ljava/lang/Object;", "GetNewDataObjectInstance_Ljava_lang_String_Handler")]
		protected override unsafe global::Java.Lang.Object NewDataObjectInstance (string p0)
		{
			if (id_newDataObjectInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_newDataObjectInstance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "newDataObjectInstance", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newDataObjectInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
