using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class ses : MonoBehaviour
    {
        private void Awake()
        {

           DontDestroyOnLoad(gameObject);
            
        }
    }
}
