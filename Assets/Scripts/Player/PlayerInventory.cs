using System.Collections.Generic;
using Items;
using UnityEngine;

namespace Player {
    public class PlayerInventory : MonoBehaviour {
        [SerializeField] private int coins;
        [SerializeField] private List<ItemBase> items;

        private void Awake() {
            items = new List<ItemBase>();
        }

        public void AddCoins(int amount) {
            coins += amount;
        }

        public void AddItem(ItemBase item) {
            items.Add(item);
        }
    }
}