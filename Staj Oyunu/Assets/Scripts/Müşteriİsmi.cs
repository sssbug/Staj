using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Müşteriİsmi : MonoBehaviour
    {
        
        [SerializeField]
        public odaVeriTabanı odaVeriTabanıı;
        GameManager gameManager;
        private void Start()
        {
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            if (collision.gameObject.layer == 6)
            {
                gameManager.sıradaki = collision.gameObject;

                odaVeriTabanıı.isim = collision.gameObject.name;
                
            }
        }
    }
}
