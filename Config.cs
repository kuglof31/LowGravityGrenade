using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Exiled.API.Interfaces;

namespace LogGravityGrenade
{
    public class Config : IConfig
    {
        [Description("Is plugin enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug mode")]
        public bool Debug { get; set; } = false;

        public List<LowGravityGrenadeItem> LogGravityGrenadeItems { get; private set; } = new List<LowGravityGrenadeItem>
        {
            new LowGravityGrenadeItem()
        };
    }
}