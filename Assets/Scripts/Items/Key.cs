using Player;

namespace Items {
    public class Key : ItemBase {
        public override void Interact(PlayerManager player) {
            player.GetInventory().AddItem(this);
            gameObject.SetActive(false);
        }
    }
}