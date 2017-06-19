using System;
using System.Collections.Generic;
using MikePhil.Charting.Data;
using MikePhil.Charting.Listener;
using MikePhil.Charting.Interfaces.Datasets;
using NativeViewBindingSample.Interfaces.Charts;
using Xamarin.Forms;
using Android.Views;

namespace NativeViewBindingSample.Droid
{
	public class DroidBarChart : MikePhil.Charting.Charts.BarChart , IOnChartGestureListenerSupport
	{
		IList<IBarChartDataEntry> _ItemsSource;
		private string _Label = string.Empty;
		public DroidBarChart(Android.Content.Context context) : base(context)
		{
            OnChartGestureListener = this;
		}
		public string Label { 
			get { return _Label; }
			set 
			{
				if (value != _Label)
				{
					_Label = value ?? string.Empty;
                    Refresh();
				}
			}
		}
		public IList<IBarChartDataEntry> ItemsSource
		{
			get
			{
				return _ItemsSource;
			}
			set
			{
				if (_ItemsSource != value)
				{
					_ItemsSource = value;
					Refresh();
				}
			}
		}

        public Command<Point> TapCommand { get; set; }

        public void OnChartDoubleTapped(MotionEvent p0)
        {
            
        }

        public void OnChartFling(MotionEvent p0, MotionEvent p1, float p2, float p3)
        {
            
        }

        public void OnChartGestureEnd(MotionEvent p0, ChartTouchListener.ChartGesture p1)
        {
            
        }

        public void OnChartGestureStart(MotionEvent p0, ChartTouchListener.ChartGesture p1)
        {
            
        }

        public void OnChartLongPressed(MotionEvent p0)
        {
            
        }

        public void OnChartScale(MotionEvent p0, float p1, float p2)
        {
            
        }

        public void OnChartSingleTapped(MotionEvent p0)
        {
            Point arg = new Point(p0.GetX(0), p0.GetY(0));
            if(TapCommand != null && p0 != null && TapCommand.CanExecute(arg)){
                TapCommand.Execute(arg);
            }
        }

        public void OnChartTranslate(MotionEvent p0, float p1, float p2)
        {
            
        }

        private void GenerateDataSet() {
			BarDataSet set = null;
			if (_ItemsSource == null || _ItemsSource.Count == 0)
			{
				set = new BarDataSet(new List<BarEntry>(), _Label);

				return;
			}
			else {
				var entries = new List<BarEntry>();
				foreach (var item in ItemsSource) {
					entries.Add(new BarEntry(item.X, new float[] { item.Y }));
				}
				set = new BarDataSet(entries, _Label);

			}
			Data = new BarData(new List<IBarDataSet>() { set });
		}
		private void Refresh() {
			GenerateDataSet();
            NotifyDataSetChanged();
			this.Invalidate();
		}
	}
}
