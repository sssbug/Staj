using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class CleanerManager : MonoBehaviour
    {
        
        [SerializeField]
        public odaVeriTabanı odaVeriTabanıı;
        
        public static CleanerManager Instance { get; private set; }
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        
        void Update()
        {
            
        }
    }
}
