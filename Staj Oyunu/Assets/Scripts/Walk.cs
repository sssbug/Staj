using Spine.Unity;
using Spine.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        GameManager gameManager = new GameManager();
        private int characterCount;
        private Vector2[] points = { new Vector2(440f, 1317.7345f), new Vector2(457.341125f, 1934.89075f) };
        private int pointCount = 0;
        private float speed = 100f;
        int counter = 0;
        int counterTwo = 0;
        SkeletonGraphic _skeletonGraphic;
        private void Awake()
        {
            _skeletonGraphic = transform.GetChild(0).transform.GetComponent<SkeletonGraphic>();
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();

        }
        private void Update()
        {
            CharacterQuery();
        }

        private void CharacterQuery()
        {

            for (int i = 0; i <= gameManager.characters.Count - 1; i++)
            {

                if (this.gameObject == gameManager.characters[i])
                {

                    characterCount = i;

                    break;
                }


            }




            if (gameManager.characters[0] == this.gameObject)
            {
                Vector2 direction = points[pointCount] - GetComponent<Rigidbody2D>().position;


                if (direction.magnitude > 0.1f)
                {

                    direction.Normalize();
                    GetComponent<Rigidbody2D>().velocity = Vector2.right;


                }
                else
                {

                    GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                }
                transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                if (gameManager.characters[0].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                {

                    if (counterTwo == 0)
                    {
                        _skeletonGraphic.startingAnimation = "İdle";
                        SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        counterTwo = 1;
                    }
                }
                else
                {
                    if (counterTwo == 1)
                    {
                        _skeletonGraphic.startingAnimation = "Walk";
                        SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        counterTwo = 0;
                    }
                }
            }
            else
            {
                if (gameManager.characters[characterCount - 1].activeSelf == false)
                {



                    if (counter == 1)
                    {
                        _skeletonGraphic.startingAnimation = "Walk";
                        SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                        counter = 0;
                    }




                    transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, gameManager.characters[characterCount - 1].transform.position + new Vector3(-350, 0, 0), speed * Time.deltaTime);
                    if (gameManager.characters[characterCount - 1].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                    {
                        if (counter == 0)
                        {
                            _skeletonGraphic.startingAnimation = "İdle";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                            counter = 1;
                        }
                    }
                }
            }




            if (gameManager.characters[0] != this.gameObject)
            {


            }
            else
            {


            }



        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "adimİlk")
            {

                //pointCount = +1;
                Debug.Log(pointCount);

                this.gameObject.SetActive(false);

            }

        }

    }
}
