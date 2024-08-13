using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class ItemsIsDestroy : MonoBehaviour
    {
        private GameManager gameManager;

        private void Start()
        {
            // GameManager referansını alın
            gameManager = FindObjectOfType<GameManager>();
        }

        private void OnDestroy()
        {
            // Obje yok olurken GameManager'a bildir
            if (gameManager != null)
            {
                gameManager.RegisterDestroyedObject(this.gameObject.name);
            }
        }

    }
}
