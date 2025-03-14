using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : ItemBase
{
    public override void Interact(Player player)
    {
        player.GetInventory().AddKey(this);
        Destroy(gameObject);
    }
}
