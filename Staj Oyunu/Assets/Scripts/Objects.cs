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
            
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();

        }

        public void OnPointerClick(PointerEventData eventData)
        {

            Debug.Log("sdfsf");
            
            GameObject clickedObject = eventData.pointerPress;
            if (clickedObject != null && clickedObject.tag == "bomb")
            {

            }
            else if (clickedObject != null && clickedObject.tag == "mektup")
            {
                GameObject slot = GameObject.Find("NotePlace");
                GameObject _myObject;
                _myObject = Instantiate(gameManager.Notlar[0]);
                
                _myObject.transform.parent = slot.transform;
                Debug.Log("sdfsf");
                GameObject.Find("Container").transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (clickedObject != null && clickedObject.tag == "mektup1")
            {
                GameObject slot = GameObject.Find("NotePlace");
                GameObject _myObject;
                _myObject = Instantiate(gameManager.Notlar[1]);

                _myObject.transform.parent = slot.transform;
                Debug.Log("sdfsf");
                GameObject.Find("Container").transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (clickedObject != null && clickedObject.name == "Anahtar")
            {

                
                gameManager.odaVeriTabanıı.oda = int.Parse(clickedObject.gameObject.transform.tag);
                gameManager.odaVeriTabanıı.odaData();
                gameManager.keys.SetActive(false);
                gameManager.cikis();
                
                
                gameManager.story.dialogSayac[gameManager.sıradakiCount] = gameManager.sayac + 1;

                

            }
          

        }
    }
}
