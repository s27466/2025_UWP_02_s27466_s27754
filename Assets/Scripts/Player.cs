using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _MaxHP;
    [SerializeField] private float _HP;
    private Inventory _inventory;

    
    public void Heal(int amount)
    {
        _HP += amount;
        _HP = Mathf.Min(_HP, _MaxHP);
    }

    public Inventory GetInventory()
    {
        return _inventory;
    }
}
