using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        public List<GameObject> adimlar;
        public float speed;

        private Animator anim;

        private float distance;
        private int adim = 0;
        // Start is called before the first frame update
        void Awake()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

            distance = Vector2.Distance(transform.position, adimlar[adim].transform.position);
            Vector2 direction = adimlar[adim].transform.position - transform.position;

            transform.position = Vector2.MoveTowards(this.transform.position, adimlar[adim].transform.position, speed * Time.deltaTime);
        }
       
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            if (collision.gameObject.tag == "adimİlk")
            {
                adim += 1;
                anim.SetBool("walk",true);
            }
            //if (collision.gameObject.tag == "orta")
            //{
            //    adim += 1;
            //    anim.SetBool("walk", false);
            //    anim.SetBool("idle", true);
            //}
            //if (collision.gameObject.tag == "ortaiki")
            //{
            //    adim += 1;
            //    anim.SetBool("walk", false);
            //    anim.SetBool("idle", true);
            //}
            //if (collision.gameObject.tag == "adimSon")
            //{
            //    adim += 1;
            //    anim.SetBool("walk", false);
            //    anim.SetBool("idle", true);
            //}
        }
    }
}
