﻿using DialogueEditor;
using DS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private NPCConversation _myConvarsation;
    [SerializeField]
    public Story story;


    public void Play()
    {
        if (story.Play == false)
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            ConversationManager.Instance.StartConversation(_myConvarsation);
        }
        else
        {
            SceneManager.LoadScene("Scene1");
        }
    }
    public void Başla()
    {
        story.Play = true;
        TimeManager.Instance.timePercent = 0.2f;
        SceneManager.LoadScene("Scene1");
        
    }
}
