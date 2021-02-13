package crc64c445c5b17bbb7e37;


public class SfGaugeRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfGauge.XForms.Droid.SfGaugeRenderer, Syncfusion.SfGauge.XForms.Android", SfGaugeRenderer.class, __md_methods);
	}


	public SfGaugeRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfGaugeRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfGauge.XForms.Droid.SfGaugeRenderer, Syncfusion.SfGauge.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SfGaugeRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfGaugeRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfGauge.XForms.Droid.SfGaugeRenderer, Syncfusion.SfGauge.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfGaugeRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfGaugeRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfGauge.XForms.Droid.SfGaugeRenderer, Syncfusion.SfGauge.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);

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
