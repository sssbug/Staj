using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        GameManager gameManager = new GameManager();
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
            
        }
    }
}
