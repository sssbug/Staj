using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private NPCConversation _myConvarsation;
    
   

    public void Play()
    {
        if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
        {
            _myConvarsation = GetComponent<NPCConversation>();
        }
        ConversationManager.Instance.StartConversation(_myConvarsation);
        
    }
    public void Başla() 
    {
        SceneManager.LoadScene("Scene1");
    }
}
