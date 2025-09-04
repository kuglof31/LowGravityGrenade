using Exiled.API.Features;
using Exiled.API.Features.Roles;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Map;
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
                new RoomSpawnPoint // új példány
                {
                    Room = RoomType.HczArmory, // hogy hova spawnoljon
                    Chance = 100f // mennyi eséllyel spawnoljon
                    

                }
            }
        };

        protected override void SubscribeEvents() // feliratkozik az eventekre az itemmel kapcsolatosan
        {
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents() // leiratkozik az eventekről az itemmel kapcsolatosan
        {
            base.UnsubscribeEvents();
        }

        protected override void OnExploding(ExplodingGrenadeEventArgs ev)
        {
            ev.TargetsToAffect.Clear();

            bool flag = !this.Check(ev.Player.CurrentItem); // lecsekkolja hogy igaz vagy hamis
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
}
