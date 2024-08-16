using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DS
{
    public class Objects : MonoBehaviour, IPointerClickHandler
    {
        private NPCConversation _myConvarsation;
        GameManager gameManager;


        private void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();

        }

        public void OnPointerClick(PointerEventData eventData)
        {


            
            GameObject clickedObject = eventData.pointerPress;

            if (clickedObject != null && clickedObject.tag == "1")
            {

                for (int i = 0; i < gameManager.inventoryItems.Count; i++)
                {
                    if (gameManager.inventoryItems[i].name == clickedObject.name)
                    {
                        Inventory halı = new Inventory(clickedObject.GetComponent<Image>().sprite, gameManager.inventoryItems[i]);
                    }
                }
                
                
                
            }
            if (clickedObject != null && clickedObject.name == "Anahtar")
            {

                
                gameManager.odaVeriTabanıı.oda = int.Parse(clickedObject.gameObject.transform.tag);
                gameManager.odaVeriTabanıı.odaData();
                gameManager.keys.SetActive(false);
                gameManager.cikis();
                
                

            }
          

        }
    }
}
