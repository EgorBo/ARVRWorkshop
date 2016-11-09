using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Urho;
using Urho.Actions;
using Urho.HoloLens;
using Urho.Shapes;

namespace MvpUrhoWorkshop.HoloLens
{
	/// <summary>
	/// Windows Holographic application using SharpDX.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		[MTAThread]
		private static void Main()
		{
			CoreApplication.Run(new AppViewSource());
		}

		class AppViewSource : IFrameworkViewSource
		{
			public IFrameworkView CreateView() => UrhoAppView.Create<MyGame>(new ApplicationOptions("Data"));
		}
	}
}