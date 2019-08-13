using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace NoFavoriteTooltips
{
    public class NoFavoriteTooltips : Mod
    {
        public class NoFavoriteTooltipsGlobalItem : GlobalItem
        {
            public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
            {
                tooltips.RemoveAll(line => line.mod == "Terraria" && line.Name.StartsWith("Favorite"));
            }
        }
    }
}