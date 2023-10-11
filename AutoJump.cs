using Terraria.ModLoader;

namespace AutoJump
{
	public class AutoJump : ModPlayer
	{
        public override void PreUpdateMovement()
        {
            Player.releaseJump = true;
            Player.rocketRelease = true;
        }
    }
}