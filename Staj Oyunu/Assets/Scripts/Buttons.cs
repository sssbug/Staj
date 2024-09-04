using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using DialogueEditor;

namespace DS
{
    public class Buttons : MonoBehaviour
    {
        private string folderPath;
        public Story story;
        private NPCConversation _myConvarsation;
        public odaVeriTabanı odaVeri;
        private void Start()
        {

            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            ConversationManager.Instance.StartConversation(_myConvarsation);
        }
        public void restrt()
        {
            folderPath = Application.persistentDataPath;

            string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");

            foreach (string file in jsonFiles)
            {
                File.Delete(file);
                Debug.Log("JSON dosyası silindi: " + file);
            }

            if (jsonFiles.Length == 0)
            {
                Debug.LogWarning("Silinecek JSON dosyası bulunamadı.");
            }
            story.ResetData();
            odaVeri.ResetData();
            SceneManager.LoadScene("Scene1");
            TimeManager.Instance.timePercent = 0.2f;
        }

    }
}
