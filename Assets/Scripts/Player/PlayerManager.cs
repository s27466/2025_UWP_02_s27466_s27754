using UnityEngine;

namespace Player {
    public class PlayerManager : MonoBehaviour {
        [SerializeField] private PlayerInventory inventory;
        [SerializeField] private PlayerHealth health;

        public PlayerInventory GetInventory() {
            return inventory;
        }

        public PlayerHealth GetHealth() {
            return health;
        }
    }
}