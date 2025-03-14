using Player;

namespace Items {
    public class HealthPotion : ItemBase{
        private const int HealthAmount = 25;

        public override void Interact(PlayerManager player) {
            player.GetHealth().Heal(HealthAmount);
            Destroy(gameObject);
        }
    }
}