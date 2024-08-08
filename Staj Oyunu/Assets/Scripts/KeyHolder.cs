using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class KeyHolder : MonoBehaviour
    {
        GameManager gameManager;
        private void Awake()
        {
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
           
        }
        private void OnEnable()
        {
            if (gameManager.odaVeriTabanıı.odadata[int.Parse(gameObject.tag)] == 0)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }
}
