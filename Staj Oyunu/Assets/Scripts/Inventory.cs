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
        string _tag;
        
        public Inventory(GameManager gm ,GameObject prefab, string tag)
        {
            
            
            _prefab = prefab;
            _gameManeger = gm;
            _tag = tag;
            Spawner();
            
            
        }
        
        void Spawner()
        {

            _myObject = Instantiate(_prefab);
            _myObject.transform.rotation = Quaternion.identity;
            _myObject.tag = _tag.ToString();
            _gameManeger.inventory.Add(_myObject);

        }
    }
}
