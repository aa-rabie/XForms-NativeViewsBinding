using System;
using System.Collections.Generic;
using MikePhil.Charting.Data;
using MikePhil.Charting.Interfaces.Datasets;
using NativeViewBindingSample.Interfaces.Charts;

namespace NativeViewBindingSample.Droid
{
	public class DroidBarChart : MikePhil.Charting.Charts.BarChart
	{
		IList<IBarChartDataEntry> _ItemsSource;
		private string _Label = string.Empty;
		public DroidBarChart(Android.Content.Context context) : base(context)
		{
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
			this.Invalidate();
		}
	}
}
