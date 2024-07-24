
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
            
            _checkPoint = checkPoint;
            _spawnCount = SpawnCount;
            

            _myChar = Instantiate(gameManager.characters[_spawnCount]);
            _myChar.gameObject.transform.parent = GameObject.Find("Canvas").gameObject.transform;
            _myChar.transform.position = _checkPoint;
            _myChar.transform.rotation = Quaternion.identity;
        }

        //isActive
        //spawnlar ve adımlar listesi olusştur ve spwanlanıp ilerleyebileceği seçenekleri olucak

    }
}
