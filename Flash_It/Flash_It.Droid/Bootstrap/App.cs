using Autofac;

namespace Flash_It.Droid.Bootstrap
{
	public static class App
	{
		private static bool _splashInitLoaded;
		private static object _splashLock = new object();

		public static IContainer Container { get; private set; }

		public static void Initialize()
		{
			lock (_splashLock)
			{
				var builder = new ContainerBuilder();
				builder.RegisterModule<RegistrationModule>();
				Container = builder.Build();
			}
		}
	}
}
