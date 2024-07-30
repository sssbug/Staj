//using DialogueEditor;
using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DS
{
    public class Objects2 : MonoBehaviour, IPointerClickHandler
    {
        private NPCConversation _myConvarsation;
        GameManager2 gameManager2;
        private GameObject bina;
        private float easing = 0.5f;
        private Vector3 _startPos;
        private Vector3 _endPos;
        public bool isLift = false;
        
        private float speed = 1;
        private void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            
            gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
            gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
            bina = GameObject.Find("Bina");
        }

        private void Update()
        {
            if (isLift == true)
            {
                Vector2 direction = new Vector2(_endPos.x,_endPos.y) - bina.transform.GetComponent<Rigidbody2D>().position;


                if (direction.magnitude > 0.1f)
                {

                    direction.Normalize();
                    bina.transform.GetComponent<Rigidbody2D>().velocity = Vector2.left;


                }
                else
                {

                    bina.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                }
                
                bina.transform.position = Vector3.MoveTowards(_startPos, _endPos, speed * Time.deltaTime);
                if (bina.transform.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                {

                    isLift = false;
                    Debug.Log(isLift);
                }
                
            }
        }
        public void OnPointerClick(PointerEventData eventData)
        {


            
            GameObject clickedObject = eventData.pointerPress;

            if (clickedObject != null && clickedObject.name == "Asansor")
            {
                gameManager2.liftButton.transform.position = clickedObject.transform.position;
                
                if (gameObject.transform.parent.name == "koridorDuvarı")
                {
                    Debug.Log(_startPos);
                    _startPos = new Vector3(570, -70, 0);
                } 
                if (gameObject.transform.parent.name == "koridorDuvarı (1)")
                {
                    Debug.Log(_startPos);
                    _startPos = new Vector3(570, 2600, 0);
                }
                
            }
            if (clickedObject != null && clickedObject.name == "ilkKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                //if (_startPos == new Vector3(0, 0, 0))
                //{
                //    bina.transform.position = new Vector3(570, -70, 0);
                //    _startPos = new Vector3(570, -70, 0);
                //}
                //else
                //{
                //    StartCoroutine(SmoothMove(_startPos, new Vector3(570, -70, 0), easing));
                //    _startPos = new Vector3(570, -70, 0);
                //}
                _endPos = new Vector3(570, -70, 0);
                
                isLift = true;
                

            }
            if (clickedObject != null && clickedObject.name == "ikinciKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                //if (_startPos == new Vector3(0,0,0))
                //{
                //    bina.transform.position = new Vector3(570, 2600, 0);
                //    _startPos = new Vector3(570, 2600, 0);
                //}
                //else
                //{
                //    StartCoroutine(SmoothMove(_startPos, new Vector3(570, 2600, 0), easing));
                //    _startPos = new Vector3(570, 2600, 0);
                //}
                _endPos = new Vector3(570, 2600, 0);
                isLift = true;
                


            }
            if (clickedObject != null && clickedObject.name == "üçüncüKat")
            {
                Debug.Log(222);
            }
            if (clickedObject != null && clickedObject.name == "dördüncüKat")
            {
                Debug.Log(222);
            }
            if (clickedObject != null && clickedObject.name == "beşinciKat")
            {
                Debug.Log(222);
            }
            if (clickedObject != null && clickedObject.name == "altıncıKat")
            {
                Debug.Log(222);
            }
            if (clickedObject != null && clickedObject.name == "ÇıkışKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
            }

        }
       
    }
}
