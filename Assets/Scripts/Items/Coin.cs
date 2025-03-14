using Player;

namespace Items {
    public class Coin : ItemBase {
        public override void Interact(PlayerManager player) {
            player.GetInventory().AddCoins(1);
            Destroy(gameObject);
        }
    }
}