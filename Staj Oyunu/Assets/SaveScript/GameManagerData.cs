using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace DS
{
    [System.Serializable]
    public class GameManagerData
    {
        public List<GameObject> charactersPrefab = new List<GameObject>();
        public List<GameObject> characters = new List<GameObject>();
        public List<GameObject> charactersBackPrefab = new List<GameObject>();
        public List<GameObject> charactersBack = new List<GameObject>();
        public List<GameObject> charactersReversePrefab = new List<GameObject>();

        public List<GameObject> inventoryItems = new List<GameObject>();
        public List<GameObject> otelinSahibi = new List<GameObject>();
        public GameObject lamba;
        public GameObject keys;

        public GameObject siradaki;
        public int spawnlanacak;
        public Light2D gunes;


        
    }
}
