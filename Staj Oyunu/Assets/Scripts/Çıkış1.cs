using DialogueEditor;
using Spine.Unity;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Çıkış1 : MonoBehaviour
    {

        private Vector2[] points = { new Vector3(-2.40f, 2.9f, 0)};
        private float speed = 1f;
        SkeletonGraphic _skeletonGraphic;
        GameManager gameManager;
        
        int basla = 1;
        int yuru = 1;
        private void Awake()
        {
            _skeletonGraphic = transform.GetChild(0).transform.GetComponent<SkeletonGraphic>();
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
        }

        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, points[0], speed * Time.deltaTime);

            Vector2 direction = points[0] - GetComponent<Rigidbody2D>().position;


            if (direction.magnitude > 0.1f)
            {

                direction.Normalize();
                if (yuru == 1)
                {
                    _skeletonGraphic.startingAnimation = "Walk";
                    
                    yuru = 0;
                }
                

            }
            else
            {
                if (basla == 1)
                {
                    GameObject spawn = Instantiate(gameManager.charactersBackPrefab[gameManager.spawnlanacak], transform.position, Quaternion.identity);

                    spawn.transform.parent = GameObject.Find("Canvas").transform;
                    Destroy(spawn.transform.GetComponent<Walk>());
                    spawn.AddComponent<ÇıkışSon1>();
                    _skeletonGraphic.startingAnimation = "İdle";
                    
                    Destroy(gameObject);
                    basla = 0;
                }
                    
                    
               



            }
        }
    }
}
