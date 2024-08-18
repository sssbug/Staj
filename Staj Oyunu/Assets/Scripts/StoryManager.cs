using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DS
{
    public class StoryManager : MonoBehaviour
    {
        GameManager gameManager;
        private NPCConversation _myConvarsation;
        private List<int> generatedNumbers = new List<int>();
        private string savePath;
        int spawnınKaldığıYer58;
        bool bitti = true;
        float eski;
        float randomWaitTime;
        void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            // Save dosyasının yolunu belirleyin
            savePath = Path.Combine(Application.persistentDataPath, "generatedNumbers.json");
            
            // Önceden kaydedilmiş sayıları yükle
            LoadGeneratedNumbers();
           
        }

        
        void Update()
        {
            //Burada dialogları başlatıyorum 
            if (gameManager.story.dialog2 == false)
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
            if (gameManager.story.müşteriBasla == true)
            {

                if (gameManager.story.dialog1 == false)
                {

                    for (int i = gameManager.story.dialog1KaldigiYer; i < 22; i++)
                    {

                        if (bitti == true)
                        {
                            misafirSpawn();
                            eski += 10;
                        }
                        //kapatıldığında nereden kaldığını al ya liste
                    }
                }
            }

        }
        public void misafirSpawn()
        {
            if (GenerateUniqueRandomNumber() != -1)
            {
                StartCoroutine(mySpawn(GenerateUniqueRandomNumber()));
                
            }
            
        }
        public int GenerateUniqueRandomNumber()
        {
            // 1-30 arası sayılardan henüz üretilmemiş olanları bul
            List<int> availableNumbers = new List<int>();

            for (int i = 1; i <= 22; i++)
            {
                if (!generatedNumbers.Contains(i))
                {
                    availableNumbers.Add(i);
                }
            }

            // Eğer üretilecek sayı kalmadıysa, -1 döndür
            if (availableNumbers.Count == 0)
            {
                Debug.Log("Tüm sayılar üretildi.");
                bitti = false;
                return -1;
            }
            

            // Rastgele bir sayı seç
            int randomIndex = Random.Range(0, availableNumbers.Count);
            int randomNumber = availableNumbers[randomIndex];

            // Sayıyı listeye ekle
            generatedNumbers.Add(randomNumber);

            // Üretilen sayıları kaydet
            SaveGeneratedNumbers();

            return randomNumber;
        }
        private void SaveGeneratedNumbers()
        {
            // Listeyi JSON formatında kaydet
            string json = JsonUtility.ToJson(new SerializableList<int>(generatedNumbers));
            File.WriteAllText(savePath, json);
            Debug.Log("Generated numbers saved.");
        }

        private void LoadGeneratedNumbers()
        {
            if (File.Exists(savePath))
            {
                string json = File.ReadAllText(savePath);
                SerializableList<int> data = JsonUtility.FromJson<SerializableList<int>>(json);
                generatedNumbers = data.List;
                Debug.Log("Generated numbers loaded.");
            }
            else
            {
                Debug.Log("No save file found.");
            }
        }
        IEnumerator mySpawn(int j)
        {
            eski += randomWaitTime;
            randomWaitTime = 20f;
            
            yield return new WaitForSeconds(eski + randomWaitTime);
            
            
            CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), j);
        }
        [System.Serializable]
        public class SerializableList<T>
        {
            public List<T> List;

            public SerializableList(List<T> list)
            {
                List = list;
            }
        }
        private void OnApplicationQuit()
        {
            
        }
    }
}
