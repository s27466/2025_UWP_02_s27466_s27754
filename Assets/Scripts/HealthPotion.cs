using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : ItemBase
{
    public int healAmount = 20;

    public override void Interact(Player player)
    {
        player.Heal(healAmount);
        Destroy(gameObject);
    }
}
