global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using Terraria;
global using Terraria.DataStructures;
global using Terraria.GameContent;
global using Terraria.ID;
global using Terraria.ModLoader;
global using Terraria.ObjectData;

namespace ReSplendent
{
	public class ReSplendent : Mod
	{
		private static ReSplendent instance;
		public static ReSplendent Instance => instance;

        public override void Load()
        {
            instance = this;
        }
        public override void Unload()
        {
            instance = null;
        }
    }
}