using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
   
    public class ButtonScript : MonoBehaviour
    {
        public GameObject keys;

        public void anahtarA�() 
        {
            keys.SetActive(true);
        }
        public void anahtarKapa()
        {
            keys.SetActive(false);
        }
    }
}
