namespace ZetaResourceEditor.Code
{
	using RuntimeBusinessLogic.Licensing;
	using Zeta.EnterpriseLibrary.Common;
	using Zeta.EnterpriseLibrary.Tools.Storage;

	internal sealed class HostSettings
	{
		private static volatile HostSettings _current;
		private static readonly object TypeLock = new object();

		public static HostSettings Current
		{
			get
			{
				if (_current == null)
				{
					lock (TypeLock)
					{
						if (_current == null)
						{
							_current = new HostSettings();
						}
					}
				}

				return _current;
			}
		}

		private ZreLicense _license;

		public ZreLicense License
		{
			get
			{
				if (_license == null)
				{
					_license = new ZreLicense();
					_license.NeedStore +=
						l => PersistanceHelper.SaveValue(@"License", l.SaveToString());

					_license.LoadFromString(PersistanceHelper.RestoreValue(@"License") as string);
				}

				return _license;
			}
		}

		public bool ShowNewsInMainWindow
		{
			get
			{
				return ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(@"ShowNewsInMainWindow"),
					false);
			}
			set { PersistanceHelper.SaveValue(@"ShowNewsInMainWindow", value); }
		}

		public bool ShowDonateButtonInMainWindow
		{
			get
			{
				return ConvertHelper.ToBoolean(
					PersistanceHelper.RestoreValue(@"ShowDonateButtonInMainWindow"),
					true);
			}
			set { PersistanceHelper.SaveValue(@"ShowDonateButtonInMainWindow", value); }
		}
	}
}