using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Discord_Raider_By_Stanley.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000023A0 File Offset: 0x000005A0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000023DA File Offset: 0x000005DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("null")]
		public string Token
		{
			get
			{
				return (string)this["Token"];
			}
			set
			{
				this["Token"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
