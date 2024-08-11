using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class OtelSahibi : MonoBehaviour
    {
        private Vector2[] points = {new Vector3(-0.2f, 3.1f, 0) };
        private float speed = 100f;
        private NPCConversation _myConvarsation;
        GameManager gameManager;
        int spawnCount;
        int başla = 1;

        public void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();

        }
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, points[0], speed * Time.deltaTime);

            Vector2 direction = points[0] - GetComponent<Rigidbody2D>().position;


            if (direction.magnitude > 0.1f)
            {

                direction.Normalize();
                


            }
            else
            {
                 
                

                
            }
        }

        public void bitti()
        {
            GameObject spawn = Instantiate(gameManager.otelinSahibi[1], transform.position, Quaternion.identity);
            spawn.transform.parent = GameObject.Find("Canvas").transform;
            spawn.AddComponent<Çıkış>();
            Destroy(gameObject);
            CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.70f, 0f, 0),15);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "orta")
            {
                ConversationManager.Instance.StartConversation(_myConvarsation);
            }
        }
    }
}
