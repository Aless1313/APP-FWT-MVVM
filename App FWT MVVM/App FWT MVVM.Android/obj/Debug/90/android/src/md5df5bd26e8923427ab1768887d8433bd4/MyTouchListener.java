package md5df5bd26e8923427ab1768887d8433bd4;


public class MyTouchListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Numericupdown.MyTouchListener, Syncfusion.SfNumericUpDown.XForms.Android", MyTouchListener.class, __md_methods);
	}


	public MyTouchListener ()
	{
		super ();
		if (getClass () == MyTouchListener.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Numericupdown.MyTouchListener, Syncfusion.SfNumericUpDown.XForms.Android", "", this, new java.lang.Object[] {  });
	}

	public MyTouchListener (md5df5bd26e8923427ab1768887d8433bd4.SfNumericUpDown p0, md5df5bd26e8923427ab1768887d8433bd4.SfNumericTextBox p1, boolean p2)
	{
		super ();
		if (getClass () == MyTouchListener.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Numericupdown.MyTouchListener, Syncfusion.SfNumericUpDown.XForms.Android", "Com.Syncfusion.Numericupdown.SfNumericUpDown, Syncfusion.SfNumericUpDown.XForms.Android:Com.Syncfusion.Numericupdown.SfNumericTextBox, Syncfusion.SfNumericUpDown.XForms.Android:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

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
