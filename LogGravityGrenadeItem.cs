<<<<<<< HEAD
﻿using Exiled.API.Features;
=======
﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Exiled.API.Features;
>>>>>>> f7ed95d637700aa61fed2a74852657cd3b906cbe
using Exiled.API.Features.Roles;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Map;
<<<<<<< HEAD
using Exiled.API.Enums;
using MEC;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Exiled.Events.EventArgs.Player;

namespace LogGravityGrenade
{
    public class LogGravityGrenadeItem : CustomGrenade
    {
        public override string Name { get; set; } = "Low Gravity Grenade";

        public override string Description { get; set; } = "LGG.";

        public override uint Id { get; set; } = 100U;

        public override ItemType Type { get; set; } = ItemType.GrenadeFlash;

        public override float Weight { get; set; } = 1f;

        public override bool ExplodeOnCollision { get; set; } = true;

        public override float FuseTime { get; set; } = 0.1f;

        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties
        {
            
            RoomSpawnPoints = new List<RoomSpawnPoint>
            {
                new RoomSpawnPoint
                {
                    Room = RoomType.HczArmory,
                    Chance = 100f
                    

                }
            }
        };

        protected override void SubscribeEvents()
        {
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            base.UnsubscribeEvents();
        }

        protected override void OnExploding(ExplodingGrenadeEventArgs ev)
        {
            ev.TargetsToAffect.Clear();

            bool flag = !this.Check(ev.Player.CurrentItem);
            if (!flag)
            {
                UnityEngine.Vector3 position = ev.Position;
                foreach (Player player in Player.List)
                {
                    bool flag2 = UnityEngine.Vector3.Distance(player.Position, position) <= 30f;
                    if (flag2)
                    {
                        Role role = player.Role;
                        FpcRole fpc = role as FpcRole;
                        bool flag3 = fpc != null;
                        if (flag3)
                        {
                            fpc.Gravity = new UnityEngine.Vector3(0f, -6f, 0f);
                            Timing.CallDelayed(30f, delegate ()
                            {
                                fpc.Gravity = UnityEngine.Vector3.down * 20f;
                            });
                        }
                    }
                }
            }
        }

    }
=======
using MEC;
using UnityEngine;

namespace LogGravityGrenade
{
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(0)]
	public class LogGravityGrenadeItem : CustomGrenade
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021A2 File Offset: 0x000003A2
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000021AA File Offset: 0x000003AA
		public override string Name { get; set; } = "Low Gravity Grenade";

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000021BB File Offset: 0x000003BB
		public override string Description { get; set; } = "LGG.";

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000021C4 File Offset: 0x000003C4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000021CC File Offset: 0x000003CC
		public override uint Id { get; set; } = 100U;

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000021D5 File Offset: 0x000003D5
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000021DD File Offset: 0x000003DD
		public override ItemType Type { get; set; } = 26;

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000021EE File Offset: 0x000003EE
		public override float Weight { get; set; } = 1f;

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000021F7 File Offset: 0x000003F7
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000021FF File Offset: 0x000003FF
		public override bool ExplodeOnCollision { get; set; } = true;

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002210 File Offset: 0x00000410
		public override float FuseTime { get; set; } = 0.1f;

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002219 File Offset: 0x00000419
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002221 File Offset: 0x00000421
		[Nullable(2)]
		public override SpawnProperties SpawnProperties { [NullableContext(2)] get; [NullableContext(2)] set; } = new SpawnProperties
		{
			RoomSpawnPoints = new List<RoomSpawnPoint>
			{
				new RoomSpawnPoint
				{
					Room = 11,
					Chance = 100f
				}
			}
		};

		// Token: 0x06000024 RID: 36 RVA: 0x0000222A File Offset: 0x0000042A
		protected override void SubscribeEvents()
		{
			base.SubscribeEvents();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002234 File Offset: 0x00000434
		protected override void UnsubscribeEvents()
		{
			base.UnsubscribeEvents();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002240 File Offset: 0x00000440
		protected override void OnExploding(ExplodingGrenadeEventArgs ev)
		{
			bool flag = !this.Check(ev.Player.CurrentItem);
			if (!flag)
			{
				Vector3 position = ev.Position;
				foreach (Player player in Player.List)
				{
					bool flag2 = Vector3.Distance(player.Position, position) <= 30f;
					if (flag2)
					{
						Role role = player.Role;
						FpcRole fpc = role as FpcRole;
						bool flag3 = fpc != null;
						if (flag3)
						{
							fpc.Gravity = new Vector3(0f, -6f, 0f);
							Timing.CallDelayed(30f, delegate()
							{
								fpc.Gravity = Vector3.down * 20f;
							});
						}
					}
				}
			}
		}
	}
>>>>>>> f7ed95d637700aa61fed2a74852657cd3b906cbe
}
