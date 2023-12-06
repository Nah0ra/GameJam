using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShop : MonoBehaviour
{
    GameData gameData;
    public int Price;

    public enum ItemType
    {
        Barricades,
        LaserTurret,
        Trap,
        Shield
    }

    public ItemType itemtype;

    private void Start() 
    {
        gameData = GameObject.Find("Scripts").GetComponent<GameData>();
    }

    public void BuyItem()
    {
        if (Price <= gameData.Scrap && Price > 0)
        {
            switch (itemtype)
            {
                case ItemType.Barricades:
                    gameData.GotBarricades = true;
                    gameData.Scrap = gameData.Scrap - Price;
                    Destroy(gameObject);
                    break;

                case ItemType.LaserTurret:
                    gameData.GotLasers = true;
                    gameData.Scrap = gameData.Scrap - Price;
                    Destroy(gameObject);
                    break;

                case ItemType.Trap:
                    gameData.GotTraps = true;
                    gameData.Scrap = gameData.Scrap - Price;
                    Destroy(gameObject);
                    break;

                case ItemType.Shield:
                    gameData.GotShields = true;
                    gameData.Scrap = gameData.Scrap - Price;
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
