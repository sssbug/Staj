using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class StoryManager : MonoBehaviour
    {
        GameManager gameManager;
        private NPCConversation _myConvarsation;
        
        void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        
        void Update()
        {
            //Burada dialogları başlatıyorum 
            if (gameManager.story.dialog1 == false)
            {
                
                for (int i = 0; i < gameManager.odaVeriTabanıı.temizlikOdalar.Length; i++)
                {
                    
                    if (gameManager.odaVeriTabanıı.temizlikOdalar[i] == true)
                    {
                        if (gameManager.story.basla  == false)
                        {
                            ConversationManager.Instance.StartConversation(_myConvarsation);
                            ConversationManager.Instance.SetInt("story", 1);
                            gameManager.story.basla = true;
                        }
                        
                        break;
                    }
                }
            }
            
            
        }
    }
}
