using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace DS
{
    public class DoorMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private float startPosX;
        private float startPosY;
        public void OnBeginDrag(PointerEventData eventData)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }

        public void OnDrag(PointerEventData eventData)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            
            this.gameObject.transform.position = new Vector3(mousePos.x + startPosX, transform.position.y, transform.position.z);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }
    }
}
