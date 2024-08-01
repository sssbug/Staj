
using Spine.Unity;
using Spine.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace DS
{
    public class Swipex : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        private Vector3 panelLocation;
        GameManager2 gameManager2;
        public float percentThreshold = 0.2f;
        public float easing = 0.5f;
        public int totalPages = 9;
        public int currentPage = 5;
        SkeletonGraphic _skeletonGraphic;

        private void Start()
        {
            _skeletonGraphic = transform.GetChild(1).transform.GetComponent<SkeletonGraphic>();
            gameManager2 = GameObject.Find("GameManager").GetComponent<GameManager2>();

            panelLocation = transform.position;
        }
        private void Update()
        {
            if (gameObject.name == "ilkKat")
            {


                if (gameManager2.isLiftOut == true)
                {

                    panelLocation = this.transform.position;
                    


                    gameManager2.isLiftOut = false;
                }
            }if (gameObject.name == "ikinciKat")
            {


                if (gameManager2.isLiftOut1 == true)
                {

                    panelLocation = this.transform.position;
                   


                    gameManager2.isLiftOut1 = false;
                }
            }if (gameObject.name == "üçüncüKat")
            {


                if (gameManager2.isLiftOut2 == true)
                {

                    panelLocation = this.transform.position;
                    


                    gameManager2.isLiftOut2 = false;
                }
            }if (gameObject.name == "DördüncüKat")
            {


                if (gameManager2.isLiftOut3 == true)
                {

                    panelLocation = this.transform.position;
                    


                    gameManager2.isLiftOut3 = false;
                }
            }
            if (gameObject.name == "beşinciKat")
            {


                if (gameManager2.isLiftOut4 == true)
                {

                    panelLocation = this.transform.position;



                    gameManager2.isLiftOut4 = false;
                }
            }
        }


        public void OnDrag(PointerEventData eventData)
        {
            if (gameManager2.isLifter == true)
            {
                float difference = eventData.pressPosition.x - eventData.position.x;
                transform.position = panelLocation - new Vector3(difference, 0, 0);
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (gameManager2.isLifter == true)
            {
                float percentage = (eventData.pressPosition.x - eventData.position.x) / Screen.width;

                if (Mathf.Abs(percentage) >= percentThreshold)
                {
                    Vector3 newLocation = panelLocation;
                    if (percentage > 0 && currentPage < totalPages)
                    {

                        currentPage++;
                        Debug.Log(currentPage);
                        newLocation += new Vector3(-Screen.width, 0, 0);
                    }
                    else if (percentage < 0 && currentPage > 1)
                    {

                        currentPage--;
                        Debug.Log(currentPage);
                        newLocation += new Vector3(Screen.width, 0, 0);
                    }
                    

                    if (gameObject.name == "beşinciKat")
                    {
                        if (currentPage == 1)
                        {
                            _skeletonGraphic.startingAnimation = "Open";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        }
                        else
                        {
                            _skeletonGraphic.startingAnimation = "Close";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        }
                    }
                    else
                    {
                        if (currentPage == 5)
                        {
                            _skeletonGraphic.startingAnimation = "Open";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        }
                        else
                        {
                            _skeletonGraphic.startingAnimation = "Close";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        }
                    }
                    StartCoroutine(SmoothMove(transform.position, newLocation, easing));
                    panelLocation = newLocation;
                }
                else
                {
                    StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
                }
            }
            



        }
        IEnumerator SmoothMove(Vector3 startPos, Vector3 endPos, float seconds)
        {
            float t = 0f;
            while (t <= 1.0)
            {
                t += Time.deltaTime / seconds;
                transform.position = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0f, 1f, t));
                yield return null;
            }
        }
    }
}
