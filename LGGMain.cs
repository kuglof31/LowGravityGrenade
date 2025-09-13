using System;
using System.Runtime.CompilerServices;
using Exiled.API.Features;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;

namespace LogGravityGrenade
{
    public class LGGMain : Plugin<Config>
    {
        public override string Name { get; } = "LGG";

        public override string Author { get; } = "NOVA";

        public override string Prefix { get; } = "LGG";

        public override Version Version { get; } = new Version(1, 1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(9, 6, 2, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            LGGMain.WeedItem = new LogGravityGrenadeItem();
            Extensions.Register(LGGMain.WeedItem);
            CustomItem.RegisterItems(false, base.Config);
            Log.Info("A customitem is registered");
        }

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

        public static LogGravityGrenadeItem WeedItem;
    }
}
