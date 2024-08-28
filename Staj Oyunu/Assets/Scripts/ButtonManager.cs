using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DS
{
    public class ButtonManager : MonoBehaviour
    {
        GameManager gameManager;
        private NPCConversation _myConvarsation;

        void Start()
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            
            
        }

        public void MektupKapat()
        {
            
            Destroy(GameObject.Find("NotePlace").transform.GetChild(0).gameObject);
            GameObject.Find("Container").transform.GetChild(1).gameObject.SetActive(false);
            if (gameManager.sıradaki.name == "Misafirlerb23(Clone)")
            {
                _myConvarsation = gameManager.sıradaki.GetComponent<NPCConversation>();
                ConversationManager.Instance.StartConversation(_myConvarsation);
                ConversationManager.Instance.SetInt("sira", 2);
            }
        }
        public void Dialog1()
        {
            gameManager.story.dialog1 = true;
            gameManager.story.basla = false;
        }
        public void Dialog2()
        {
            gameManager.story.dialog2 = true;
            gameManager.story.basla = false;
        }
        public void Dialog3()
        {
            gameManager.story.dialog3 = true;
            gameManager.story.basla = false;
        }
        public void Dialog4()
        {
            gameManager.story.dialog4 = true;
            gameManager.story.basla = false;
        }
        public void Dialog5()
        {
            gameManager.story.dialog5 = true;
            gameManager.story.basla = false;
        }
        public void Dialog6()
        {
            gameManager.story.dialog6 = true;
            gameManager.story.basla = false;
        }
        public void Dialog7()
        {
            gameManager.story.dialog7 = true;
            gameManager.story.basla = false;
        }
        public void Dialog8()
        {
            gameManager.story.dialog8 = true;
            gameManager.story.basla = false;
        }
        public void Dialog9()
        {
            gameManager.story.dialog9 = true;
            gameManager.story.basla = false;
        }
        public void Dialog10()
        {
            gameManager.story.dialog10 = true;
            gameManager.story.basla = false;
        }
        public void Dialog11()
        {
            gameManager.story.dialog11 = true;
            gameManager.story.basla = false;
        }
        public void Dialog12()
        {
            gameManager.story.dialog12 = true;
            gameManager.story.basla = false;
        }
        public void Dialog13()
        {
            gameManager.story.dialog13 = true;
            gameManager.story.basla = false;
        }
        public void Dialog14()
        {
            gameManager.story.dialog14 = true;
            gameManager.story.basla = false;
        }
        public void Dialog15()
        {
            gameManager.story.dialog15 = true;
            gameManager.story.basla = false;
        }
        public void Dialog16()
        {
            gameManager.story.dialog16 = true; gameManager.story.basla = false;
        }
        public void Dialog17()
        {
            gameManager.story.dialog17 = true; gameManager.story.basla = false;
        }
        public void Dialog18()
        {
            gameManager.story.dialog18 = true; gameManager.story.basla = false;
        }
        public void Dialog19()
        {
            gameManager.story.dialog19 = true; gameManager.story.basla = false;
        }
        public void Dialog20()
        {
            gameManager.story.dialog20 = true; gameManager.story.basla = false;
        }
        public void Dialog21()
        {
            gameManager.story.dialog21 = true; gameManager.story.basla = false;
        }
        public void Dialog22()
        {
            gameManager.story.dialog22 = true; gameManager.story.basla = false;
        }
        public void Dialog23()
        {
            gameManager.story.dialog23 = true; gameManager.story.basla = false;
        }


        

    }
}
