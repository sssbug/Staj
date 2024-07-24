using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        GameManager gameManager = new GameManager();
        private int characterCount;
        private Vector2[] points = {new Vector2(535.586365f, 1342.00879f), new Vector2(-127.658875f, 49.5609131f)};
        private int pointCount = 0;
        private int speed = 100;
        private void Awake()
        {
            
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
                    Debug.Log(characterCount);
                    break;
                }

                
            }
            if (gameManager.characters.Count == 1 )
            {

                transform.position = Vector3.MoveTowards(transform.position, points[0], speed*Time.deltaTime);
                //Vector2(-76.6679382f, -532.699402f)
            }
            else
            {
                if (gameManager.characters[characterCount - 1].activeSelf == false)
                {
                    transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, gameManager.characters[characterCount - 1].transform.position, speed * Time.deltaTime);

                }
            }
            
        }
    }
}
