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
        private string _name;
        public Inventory(Sprite objectImage, string name)
        {
            _objectImage = objectImage;
            _name = name;

            Spawner();
            
            
        }
        void Spawner()
        {

            GameObject theObject = new GameObject(_name);
            theObject.AddComponent<CanvasRenderer>();
            theObject.AddComponent<Objects>();
            theObject.AddComponent<Image>().sprite = _objectImage;

            _myObject = Instantiate(theObject);

            _myObject.gameObject.transform.parent = GameObject.Find("SlotBox").gameObject.transform;
            
        }
    }
}
