using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class GameController : MonoBehaviour
    {
        public ObjectManager objectManager;

        private void Start()
        {
            // Sahne yüklendiğinde objeleri yükle
            objectManager.LoadObjects();
        }

        private void OnApplicationQuit()
        {
            // Oyun kapanırken objeleri kaydet
            objectManager.SaveObjects();
        }

        public void SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation, int layer)
        {
            GameObject obj = Instantiate(prefab, position, rotation);
            obj.layer = layer;
        }
    }
}
