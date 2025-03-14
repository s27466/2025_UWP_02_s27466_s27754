using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ItemBase
{
    public override void Interact(Player player)
    {
        player.GetInventory().AddCoins(1);
        Destroy(gameObject);
    }
}
