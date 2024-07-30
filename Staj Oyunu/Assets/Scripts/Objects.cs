//using DialogueEditor;
using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DS
{
    public class Objects : MonoBehaviour, IPointerClickHandler
    {
        private NPCConversation _myConvarsation;
        GameObject lift;


        private void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            if (lift.activeInHierarchy)
            {
                lift = GameObject.Find("LiftButton");
                lift.SetActive(false);
            }

        }

        public void OnPointerClick(PointerEventData eventData)
        {


            
            GameObject clickedObject = eventData.pointerPress;

            if (clickedObject != null && clickedObject.tag == "1")
            {
                ConversationManager.Instance.StartConversation(_myConvarsation);
                //Inventory halı = new Inventory(clickedObject.GetComponent<Image>().sprite, "hali");
            }
            if (clickedObject != null && clickedObject.name == "hali(Clone)")
            {
                Debug.Log(222);
            }
          

        }
    }
}
