using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace DS
{
    public class Inventory : MonoBehaviour
    {
        
        private GameObject _myObject;
        
        private GameObject _prefab;

        private GameManager _gameManeger;
        
        
        public Inventory(GameManager gm ,GameObject prefab)
        {
            
            
            _prefab = prefab;
            _gameManeger = gm;
            Spawner();
            
            
        }
        
        void Spawner()
        {

            _myObject = Instantiate(_prefab);
            _myObject.transform.rotation = Quaternion.identity;
            _gameManeger.inventory.Add(_myObject);

        }
    }
}
