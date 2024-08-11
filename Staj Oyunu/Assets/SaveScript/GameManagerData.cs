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


        public GameManagerData(List<GameObject> _charactersPrefab, List<GameObject> _characters, 
            List<GameObject> _charactersBackPrefab, List<GameObject> _charactersBack, List<GameObject> _charactersReversePrefab, 
            List<GameObject> _inventoryItems, List<GameObject> _otelinSahibi, GameObject _lamba, 
            GameObject _keys, GameObject _siradaki, int _spawnlanacak) 
        {
            foreach (var item in _characters)
            {
                characters = _characters;
            }
            foreach (var item in _charactersBack)
            {
                charactersBack = _charactersBack;
            }
            foreach (var item in _charactersBackPrefab)
            {
                charactersBackPrefab = _charactersBackPrefab;
            }
            foreach (var item in _charactersPrefab)
            {
                charactersPrefab = _charactersPrefab;
            }
            foreach (var item in _charactersReversePrefab)
            {
                charactersReversePrefab = _charactersReversePrefab;
            }
            foreach (var item in _inventoryItems)
            {
                inventoryItems = _inventoryItems;
            }
            foreach (var item in _otelinSahibi)
            {
                otelinSahibi = _otelinSahibi;
            }
            lamba = _lamba;
            keys = _keys;
            siradaki = _siradaki;
            spawnlanacak = _spawnlanacak;
        }
    }
}
