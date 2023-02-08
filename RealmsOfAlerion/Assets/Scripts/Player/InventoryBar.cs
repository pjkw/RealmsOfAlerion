using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBar : MonoBehaviour
{
    // add stone later
    [SerializeField] Text foodText;
    [SerializeField] Text woodText;
    [SerializeField] Text magicText;
    [SerializeField] Text manaText;
    [SerializeField] Text goldText;

    void Start()
    {
        SetInventory();
    }

    void SetInventory()
    {
        foodText.text = Inventory.instance.player1Resources.food.ToString();
        woodText.text = Inventory.instance.player1Resources.wood.ToString();
        magicText.text = Inventory.instance.player1Resources.magic.ToString();
        manaText.text = Inventory.instance.player1Resources.mana.ToString();
        goldText.text = Inventory.instance.player1Resources.gold.ToString();
    }

    // we will also need a way to update the player's 2 resources

    public void UpdateText()
    {
        foodText.text = Inventory.instance.player1Resources.food.ToString();
        woodText.text = Inventory.instance.player1Resources.wood.ToString();
        magicText.text = Inventory.instance.player1Resources.magic.ToString();
        manaText.text = Inventory.instance.player1Resources.mana.ToString();
        goldText.text = Inventory.instance.player1Resources.gold.ToString();
    }
}