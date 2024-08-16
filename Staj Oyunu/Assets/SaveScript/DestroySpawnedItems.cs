using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class DestroySpawnedItems : MonoBehaviour
    {
        ObjectManager objectManager;
        GameManager gameManager;
        void Awake()
        {
            objectManager = GameObject.Find("ObjectManager").GetComponent<ObjectManager>();
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        private void OnDestroy()
        {
            objectManager.layeredObjectsData.Clear();
            if (this.gameObject.activeSelf == false)
            {
                if (gameManager.loadedCharactersNames.Contains(gameObject.name.Replace("(Clone)", "").Trim()))
                {
                    gameManager.characters.Remove(gameObject);
                }
                if (gameManager.loadedCharactersBackNames.Contains(gameObject.name.Replace("(Clone)", "").Trim()))
                {
                    gameManager.charactersBack.Remove(gameObject);
                }
            }
            
        }
    }
}
