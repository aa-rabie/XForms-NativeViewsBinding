using System;
using NativeViewBindingSample.Interfaces.Charts;

namespace NativeViewBindingSample
{
	public class BarChartDataEntry : IBarChartDataEntry
	{
		private float x, y;
		public BarChartDataEntry()
		{
		}

		public float X
		{
			get
			{
				return x;
			}

			set
			{
				x = value;
			}
		}

		public float Y
		{
			get
			{
				return y;
			}

			set
			{
				y = value;
			}
		}
	}
}
