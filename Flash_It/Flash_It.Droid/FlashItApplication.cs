using Android.App;
using Autofac;
using Flash_It.Droid.Bootstrap;
using Flash_It.Droid.Helpers;

namespace Flash_It.Droid
{
	[Application]
	public class FlashItApplication : Application
	{
		public override void OnCreate()
		{
			base.OnCreate();

			App.Initialize();

			DoSetup();
		}

		private void DoSetup()
		{
			var setup = App.Container.Resolve<InitialSetup>();
			setup.DoInitialSetup();
		}
	}
}
