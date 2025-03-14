using Items;
using Player;
using UnityEngine;

public class ItemCollector : MonoBehaviour {
    [SerializeField] private PlayerManager playerManager;
    
    private void OnTriggerEnter(Collider other) {
        var item = other.GetComponent<ItemBase>();
        item?.Interact(playerManager);
    }
}