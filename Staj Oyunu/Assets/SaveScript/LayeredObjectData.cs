using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    [System.Serializable]
    public class LayeredObjectData
    {
        public Vector3 position;  // Objeyi sahnede nereye koyacağınız
        public Quaternion rotation;  // Objeyi hangi yönde koyacağınız
        public string prefabName;  // Objeyi oluşturduğunuz prefabın ismi

        public LayeredObjectData(Vector3 pos, Quaternion rot, string prefab)
        {
            position = pos;
            rotation = rot;
            prefabName = prefab;
        }
    }
}
