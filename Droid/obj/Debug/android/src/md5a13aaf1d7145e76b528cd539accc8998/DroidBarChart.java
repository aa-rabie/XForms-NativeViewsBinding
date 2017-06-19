package md5a13aaf1d7145e76b528cd539accc8998;


public class DroidBarChart
	extends com.github.mikephil.charting.charts.BarChart
	implements
		mono.android.IGCUserPeer,
		com.github.mikephil.charting.listener.OnChartGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChartDoubleTapped:(Landroid/view/MotionEvent;)V:GetOnChartDoubleTapped_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartFling:(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)V:GetOnChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartGestureEnd:(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V:GetOnChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartGestureStart:(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V:GetOnChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartLongPressed:(Landroid/view/MotionEvent;)V:GetOnChartLongPressed_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartScale:(Landroid/view/MotionEvent;FF)V:GetOnChartScale_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartSingleTapped:(Landroid/view/MotionEvent;)V:GetOnChartSingleTapped_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"n_onChartTranslate:(Landroid/view/MotionEvent;FF)V:GetOnChartTranslate_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, MPAndroidChart\n" +
			"";
		mono.android.Runtime.register ("NativeViewBindingSample.Droid.DroidBarChart, NativeViewBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DroidBarChart.class, __md_methods);
	}


	public DroidBarChart (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == DroidBarChart.class)
			mono.android.TypeManager.Activate ("NativeViewBindingSample.Droid.DroidBarChart, NativeViewBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public DroidBarChart (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == DroidBarChart.class)
			mono.android.TypeManager.Activate ("NativeViewBindingSample.Droid.DroidBarChart, NativeViewBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public DroidBarChart (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == DroidBarChart.class)
			mono.android.TypeManager.Activate ("NativeViewBindingSample.Droid.DroidBarChart, NativeViewBindingSample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onChartDoubleTapped (android.view.MotionEvent p0)
	{
		n_onChartDoubleTapped (p0);
	}

	private native void n_onChartDoubleTapped (android.view.MotionEvent p0);


	public void onChartFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3)
	{
		n_onChartFling (p0, p1, p2, p3);
	}

	private native void n_onChartFling (android.view.MotionEvent p0, android.view.MotionEvent p1, float p2, float p3);


	public void onChartGestureEnd (android.view.MotionEvent p0, com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture p1)
	{
		n_onChartGestureEnd (p0, p1);
	}

	private native void n_onChartGestureEnd (android.view.MotionEvent p0, com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture p1);


	public void onChartGestureStart (android.view.MotionEvent p0, com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture p1)
	{
		n_onChartGestureStart (p0, p1);
	}

	private native void n_onChartGestureStart (android.view.MotionEvent p0, com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture p1);


	public void onChartLongPressed (android.view.MotionEvent p0)
	{
		n_onChartLongPressed (p0);
	}

	private native void n_onChartLongPressed (android.view.MotionEvent p0);


	public void onChartScale (android.view.MotionEvent p0, float p1, float p2)
	{
		n_onChartScale (p0, p1, p2);
	}

	private native void n_onChartScale (android.view.MotionEvent p0, float p1, float p2);


	public void onChartSingleTapped (android.view.MotionEvent p0)
	{
		n_onChartSingleTapped (p0);
	}

	private native void n_onChartSingleTapped (android.view.MotionEvent p0);


	public void onChartTranslate (android.view.MotionEvent p0, float p1, float p2)
	{
		n_onChartTranslate (p0, p1, p2);
	}

	private native void n_onChartTranslate (android.view.MotionEvent p0, float p1, float p2);

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
