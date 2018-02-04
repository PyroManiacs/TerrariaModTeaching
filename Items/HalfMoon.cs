using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Revaluations.Items
{
	public class HalfMoon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Half-Moon");
			Tooltip.SetDefault("The crusher of moons!.");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 10;
			item.pick = 250;
            item.axe = 40;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 10);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.Emerald, 10);
            recipe.AddIngredient(ItemID.Amethyst, 10);
            recipe.AddIngredient(ItemID.HallowedBar, 45);
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddTile(null, "CrystalForge");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}