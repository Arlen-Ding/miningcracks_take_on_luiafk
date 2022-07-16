using miningcracks_take_on_luiafk.Utility;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Thrown
{
	public class UnlimitedHappyGrenade : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Happy Grenades");
			base.Tooltip.SetDefault("Never run out of Happy Grenades.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.CloneAmmoThrown(base.Item, 3548, usable: true);
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(3548, 396).AddTile(18).Register();
		}
	}
}
