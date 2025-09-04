using System;
using System.Runtime.CompilerServices;
using Exiled.API.Features;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;

namespace LogGravityGrenade
{
	// Token: 0x02000006 RID: 6
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LGGMain : Plugin<Config>
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020EB File Offset: 0x000002EB
		public override string Name
		{
			get
			{
				return "LGG";
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020F2 File Offset: 0x000002F2
		public override string Author
		{
			get
			{
				return "I'm not playing in real life";
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020F9 File Offset: 0x000002F9
		public override string Prefix
		{
			get
			{
				return "LGG";
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002100 File Offset: 0x00000300
		public override Version Version
		{
			get
			{
				return new Version(1, 0, 0);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000210A File Offset: 0x0000030A
		public override Version RequiredExiledVersion
		{
			get
			{
				return new Version(8, 5, 0);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002114 File Offset: 0x00000314
		public override void OnEnabled()
		{
			base.OnEnabled();
			LGGMain.WeedItem = new LogGravityGrenadeItem();
			Extensions.Register(LGGMain.WeedItem);
			CustomItem.RegisterItems(false, base.Config);
			Log.Info("LGG зарегистрирован!");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000214C File Offset: 0x0000034C
		public override void OnDisabled()
		{
			base.OnDisabled();
			bool flag = LGGMain.WeedItem != null;
			if (flag)
			{
				Extensions.Unregister(LGGMain.WeedItem);
				CustomItem.Registered.Remove(LGGMain.WeedItem);
				LGGMain.WeedItem = null;
			}
			CustomItem.UnregisterItems();
		}

		// Token: 0x04000006 RID: 6
		[Nullable(2)]
		public static LogGravityGrenadeItem WeedItem;
	}
}
