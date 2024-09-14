
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class CharacterSpawn : MonoBehaviour
    {

        GameManager gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
        private Vector2 checkPoint;
        private int SpawnCount;
        public int gameTime;
        private GameObject _myChar;

        public CharacterSpawn(Vector2 _checkPoint, int _spawnCount)
        {

            checkPoint = _checkPoint;
            SpawnCount = _spawnCount;


            _myChar = Instantiate(gameManager.charactersPrefab[_spawnCount]);
            _myChar.gameObject.transform.parent = GameObject.Find("Canvas").gameObject.transform;
            _myChar.transform.position = _checkPoint;
            _myChar.transform.rotation = Quaternion.identity;
            gameManager.characters.Add(_myChar);
            gameManager.charactersPrefabNames.Add(_myChar.name);


        }


    }
}
