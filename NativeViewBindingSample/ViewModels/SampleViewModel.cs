using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using NativeViewBindingSample.Interfaces.Charts;

namespace NativeViewBindingSample
{
	public class SampleViewModel : INotifyPropertyChanged
	{
		private List<BarChartDataEntry> dataItems;
		public SampleViewModel()
		{
			dataItems = new List<BarChartDataEntry>();
			LoadData();
		}
		void LoadData() {
			dataItems = new List<BarChartDataEntry>() {
				new BarChartDataEntry(){X=0,Y=30},
				new BarChartDataEntry() { X =1,Y=80},
				new BarChartDataEntry() { X = 2,Y = 60},
				new BarChartDataEntry() { X = 3,Y=50},
				new BarChartDataEntry() { X = 5,Y = 70},
				new BarChartDataEntry() { X = 6,Y=60}
			};
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		public List<IBarChartDataEntry> DataItems {
            get { return dataItems == null ? null : (from i in dataItems select i as IBarChartDataEntry).ToList() ; }

		}

        public string ChartLabel{
            get { return "Sample Native BarChart"; }
        }
	}
}
