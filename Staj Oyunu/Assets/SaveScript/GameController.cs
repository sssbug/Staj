using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class GameController : MonoBehaviour
    {
        public ObjectManager objectManager;
        public GameManager manager;
        private void Start()
        {
            // Sahne yüklendiğinde objeleri yükle
            manager.LoadGame();
            objectManager.LoadObjects();

            //CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), 1);
        }

        private void OnApplicationQuit()
        {
            // Oyun kapanırken objeleri kaydet
            manager.SaveGame();
            objectManager.SaveObjects();
            
        }

        public void SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation, int layer)
        {
            GameObject obj = Instantiate(prefab, position, rotation);
            obj.layer = layer;
        }
    }
}
