using Player;
using UnityEngine;

namespace Items {
    public abstract class ItemBase : MonoBehaviour {
        public abstract void Interact(PlayerManager player);
    }
}