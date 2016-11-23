using Autofac;
using Flash_It.Droid.Helpers;
using Flash_It.Droid.Utils;

namespace Flash_It.Droid.Bootstrap
{
	public class RegistrationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			RegisterHelpers(builder);
			RegisterUtils(builder);
		}

		private void RegisterHelpers(ContainerBuilder builder)
		{
			builder.RegisterType<InitialSetup>();
			builder.RegisterType<Preference>();
		}

		private void RegisterUtils(ContainerBuilder builder)
		{
			builder.RegisterType<BatteryUtil>();
			builder.RegisterType<CameraUtil>();
			builder.RegisterType<RingerUtil>();
		}
	}
}
