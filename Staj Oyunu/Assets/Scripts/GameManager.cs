using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    //new Vector2(-110.886909f, 1271.63879f)


    public class GameManager : MonoBehaviour
    {

        public List<GameObject> charactersPrefab = new List<GameObject>();
        public List<GameObject> characters = new List<GameObject>();
        public List<GameObject> charactersBackPrefab = new List<GameObject>();
        public List<GameObject> charactersBack = new List<GameObject>();
        private void Start()
        {
           
            Invoke("spawner",2);
        }
        void spawner()
        {
            CharacterSpawn walk = new CharacterSpawn(new Vector2(-110.886909f, 1271.63879f), 1);
        }
    }
}
