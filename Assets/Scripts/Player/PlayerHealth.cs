using UnityEngine;

namespace Player {
    public class PlayerHealth : MonoBehaviour {
        private const int MaxHealth = 100;
        [SerializeField] private int currentHealth;

        private void Awake() {
            currentHealth = MaxHealth;
        }

        public void Heal(int amount) {
            currentHealth = Mathf.Min(MaxHealth, currentHealth + amount);
        }
    }
}