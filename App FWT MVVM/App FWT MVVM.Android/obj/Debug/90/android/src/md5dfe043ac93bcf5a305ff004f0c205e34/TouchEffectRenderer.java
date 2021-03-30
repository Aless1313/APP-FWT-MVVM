package md5dfe043ac93bcf5a305ff004f0c205e34;


public class TouchEffectRenderer
	extends md502be9c66b0fa458cda86488a47aefb89.SfEffectsViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.XForms.Android.Buttons.TouchEffectRenderer, Syncfusion.Buttons.XForms.Android", TouchEffectRenderer.class, __md_methods);
	}


	public TouchEffectRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TouchEffectRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.Buttons.TouchEffectRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TouchEffectRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TouchEffectRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.Buttons.TouchEffectRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TouchEffectRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TouchEffectRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.Buttons.TouchEffectRenderer, Syncfusion.Buttons.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
