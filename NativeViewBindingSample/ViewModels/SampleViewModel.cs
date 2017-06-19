using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using NativeViewBindingSample.Interfaces.Charts;
using Xamarin.Forms;

namespace NativeViewBindingSample
{
	public class SampleViewModel : INotifyPropertyChanged
	{
		private List<BarChartDataEntry> dataItems;
        private string message;
		public SampleViewModel()
		{
            Message = "Tap on Chart";
			dataItems = new List<BarChartDataEntry>();
			LoadData();
            TapCmd = new Command<Point>( (p) => {
                Message = $"you clicked at ({p.X.ToString("####")} , {p.Y.ToString("####")})";
            });
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

        public Command<Point> TapCmd { get; set; }
        public string ChartLabel{
            get { return "Sample Native BarChart"; }
        }

		public string Message
		{
            get { return message; }
            set 
            { 
                if(value != message){
                    message = value;
                    OnPropertyChanged(nameof(Message));
                } 
            }
		}

	}
}
