using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DS
{
    public class Swipe : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        private Vector3 panelLocation;
        GameManager gameManager;
        
        

        private void Awake()
        {
            
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

            panelLocation = transform.localPosition;
        }
        


        public void OnDrag(PointerEventData eventData)
        {
            
            float difference = eventData.pressPosition.x - eventData.position.x;
            transform.localPosition = panelLocation - new Vector3(difference, 0, 0);
            
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (transform.localPosition.x < -840)
            {
                transform.localPosition = new Vector3(-840, -765,0);
            }
            if (transform.localPosition.x > 840)
            {
                transform.localPosition = new Vector3(840,-765,0);
            }
            panelLocation = transform.localPosition;
        }
       
    }
}
