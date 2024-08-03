using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace DS
{
    public class Inventory : MonoBehaviour
    {
        private Sprite _objectImage;
        private GameObject _myObject;
        
        private GameObject _prefab;
        
        public Inventory(Sprite objectImage, GameObject prefab)
        {
            _objectImage = objectImage;
            
            _prefab = prefab;
            Spawner();
            
            
        }
        void Spawner()
        {

            _myObject = Instantiate(_prefab);
            _myObject.transform.rotation = Quaternion.identity;
            _myObject.gameObject.transform.parent = GameObject.Find("SlotBox").gameObject.transform;

        }
    }
}
