using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class InventoryRealtime : MonoBehaviour
    {
        GameManager gameManager;
        

        void Awake()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            
        }

        
        void Update()
        {
            if (gameManager.inventory.Count != 0)
            {
                foreach (var item in gameManager.inventory)
                {
                    item.transform.parent = gameManager.slot.transform;

                }
            }
        }

    }
}
