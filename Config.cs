using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Exiled.API.Interfaces;

namespace LogGravityGrenade
{
	// Token: 0x02000005 RID: 5
	[NullableContext(1)]
	[Nullable(0)]
	public class Config : IConfig
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000208A File Offset: 0x0000028A
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002092 File Offset: 0x00000292
		[Description("Is plugin enabled or not")]
		public bool IsEnabled { get; set; } = true;

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000209B File Offset: 0x0000029B
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020A3 File Offset: 0x000002A3
		[Description("Debug mode")]
		public bool Debug { get; set; } = false;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020AC File Offset: 0x000002AC
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020B4 File Offset: 0x000002B4
		public List<LogGravityGrenadeItem> LogGravityGrenadeItems { get; private set; } = new List<LogGravityGrenadeItem>
		{
			new LogGravityGrenadeItem()
		};
	}
}
