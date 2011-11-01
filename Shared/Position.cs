using System;

namespace MonoMobile.Extensions
{
	public class Position
	{
		public DateTimeOffset Timestamp
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		public double Latitude
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		public double Longitude
		{
			get;
			set;
		}

		public double Altitude
		{
			get;
			set;
		}

		public double Accuracy
		{
			get;
			set;
		}

		public double AltitudeAccuracy
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the heading in degrees relative to true North.
		/// </summary>
		public double Heading
		{
			get;
			set;
		}

		public double Speed
		{
			get;
			set;
		}
	}
}