//using DialogueEditor;
using DialogueEditor;
using Spine.Unity;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DS
{
    public class Objects2 : MonoBehaviour, IPointerClickHandler
    {
        private NPCConversation _myConvarsation;
        GameManager2 gameManager2;
        private GameObject bina;
        private float easing = 0.5f;
        public bool isLift = false;
        private Vector3 _endPos;
        SkeletonGraphic[] _skeletonGraphic;
        GameObject[] sakınsilme;
        private float speed = 1;
        private void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }

            sakınsilme = GameObject.FindGameObjectsWithTag("Asansor");

            gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();
            gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
            bina = GameObject.Find("Bina");
        }

        private void Update()
        {
            if (isLift == true)
            {
                Vector2 direction = new Vector2(_endPos.x, _endPos.y) - bina.transform.GetComponent<Rigidbody2D>().position;


                if (direction.magnitude > 0.1f)
                {

                    direction.Normalize();
                    bina.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f, 0);


                }
                else
                {
                    gameManager2.isLiftOut = true;
                    gameManager2.isLiftOut1 = true;
                    gameManager2.isLiftOut2 = true;
                    gameManager2.isLiftOut3 = true;
                    gameManager2.isLiftOut4 = true;
                    bina.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;


                }


                bina.transform.position = Vector3.Lerp(bina.transform.position, _endPos, speed * Time.deltaTime);


                if (bina.transform.GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                {

                    gameManager2.isLifter = true;
                    isLift = false;
                    foreach (var item in sakınsilme)
                    {
                        _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                        foreach (var items in _skeletonGraphic)
                        {
                            items.AnimationState.SetAnimation(1, "Open", false);
                        }

                    }
                }

            }
        }
        public void OnPointerClick(PointerEventData eventData)
        {


            GameObject clickedObject = eventData.pointerPress;


            if (gameManager2.isLifter == true)
            {
                if (clickedObject != null && clickedObject.name == "Asansor")
                {

                    gameManager2.liftButton.transform.position = clickedObject.transform.position + new Vector3(-0.31f,1,0);
                }
            }

            if (clickedObject != null && clickedObject.name == "ilkKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);


                gameManager2.isLifter = false;

                foreach (var item in sakınsilme)
                {
                    _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                    foreach (var items in _skeletonGraphic)
                    {
                        items.AnimationState.SetAnimation(1, "Close", false);

                    }

                }

                isLift = true;
                _endPos = new Vector3(0f, -5.25f, 0);
            }
            if (clickedObject != null && clickedObject.name == "ikinciKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                gameManager2.isLifter = false;


                foreach (var item in sakınsilme)
                {
                    _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                    foreach (var items in _skeletonGraphic)
                    {
                        items.AnimationState.SetAnimation(1, "Close", false);

                    }

                }

                isLift = true;
                _endPos = new Vector3(0f, 5.25f, 0);
            }
            if (clickedObject != null && clickedObject.name == "üçüncüKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                gameManager2.isLifter = false;

                foreach (var item in sakınsilme)
                {
                    _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                    foreach (var items in _skeletonGraphic)
                    {
                        items.AnimationState.SetAnimation(1, "Close", false);

                    }

                }

                isLift = true;
                _endPos = new Vector3(0f, 16f, 0);
            }
            if (clickedObject != null && clickedObject.name == "dördüncüKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                gameManager2.isLifter = false;

                foreach (var item in sakınsilme)
                {
                    _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                    foreach (var items in _skeletonGraphic)
                    {
                        items.AnimationState.SetAnimation(1, "Close", false);

                    }

                }

                isLift = true;
                _endPos = new Vector3(0f, 26.60f, 0);
            }
            if (clickedObject != null && clickedObject.name == "beşinciKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                gameManager2.isLifter = false;
                _endPos = new Vector3(0f, 37.30f, 0);
                isLift = true;
                foreach (var item in sakınsilme)
                {
                    _skeletonGraphic = item.transform.GetComponents<SkeletonGraphic>();
                    foreach (var items in _skeletonGraphic)
                    {
                        items.AnimationState.SetAnimation(1, "Close", false);

                    }

                }
            }
            if (clickedObject != null && clickedObject.name == "ÇıkışKat")
            {
                gameManager2.liftButton.transform.position = new Vector3(100587, 100045, 0);
                SceneManager.LoadScene("Scene1");
            }

        }

    }
}
