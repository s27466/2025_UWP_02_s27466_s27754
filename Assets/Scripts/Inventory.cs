using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int coins = 0;
    private List<Key> keys = new List<Key>();
    
    public void AddCoins(int amount)
    {
        coins += amount;
    }

    public void AddKey(Key key)
    {
        keys.Add(key);
    }
}
