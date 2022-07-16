using miningcracks_take_on_luiafk.Utility;
using Terraria.ModLoader;

namespace miningcracks_take_on_luiafk.Images.Items.Bullets
{
	public class UnlimitedPartyBullets : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Unlimited Party Bullets");
			base.Tooltip.SetDefault("Never run out of Party Bullets.");
			base.SacrificeTotal = 1;
		}

		public override void SetDefaults()
		{
			Defaults.CloneAmmoThrown(base.Item, 1349);
		}

		public override void AddRecipes()
		{
			CreateRecipe().AddIngredient(1349, 3996).AddTile(18).Register();
		}
	}
}
