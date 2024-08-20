using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;
namespace DS
{
    public class StoryManager : MonoBehaviour
    {
        GameManager gameManager;
        private NPCConversation _myConvarsation;
        private List<int> generatedNumbers = new List<int>();
        private string savePath;
        bool bitti = true;
        public float interval = 5f;  // Her 20 saniyede bir çalışacak
        public int maxCalls = 23;     // Fonksiyon toplamda 23 kere çalışacak

        private int currentCallCountLocal;
        private float timerLocal;

        bool basla = true;
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
            LoadProgress(); // Uygulama açıldığında ilerlemeyi yükle

            if (currentCallCountLocal < maxCalls)
            {
                timerLocal = interval - timerLocal; // Kaldığı yerden devam edebilmesi için kalan süreyi hesapla
            }
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
                        if (gameManager.story.basla == false)
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



                    if (currentCallCountLocal < maxCalls)
                    {
                        timerLocal += Time.deltaTime;

                        if (timerLocal >= interval)
                        {

                            misafirSpawn();

                            currentCallCountLocal++;
                            timerLocal = 0f; // Zamanlayıcıyı sıfırla

                            SaveProgress(); // Her işlemde ilerlemeyi kaydet



                        }
                    }
                    else
                    {
                        gameManager.story.dialog1 = true;
                        gameManager.story.müşteriBasla = false;
                    }



                }
            }

        }
        public void misafirSpawn()
        {
            int generated = GenerateUniqueRandomNumber();
            if (generated != -1)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), generated);

            }

        }
        public int GenerateUniqueRandomNumber()
        {
            // 1-30 arası sayılardan henüz üretilmemiş olanları bul
            List<int> availableNumbers = new List<int>();

            for (int i = 0; i <= 22; i++)
            {
                if (!generatedNumbers.Contains(i))
                {
                    availableNumbers.Add(i);

                }
            }

            // Eğer üretilecek sayı kalmadıysa, -1 döndür
            if (availableNumbers.Count == 1)
            {
                Debug.Log("Tüm sayılar üretildi.");

                return -1;
            }

            Debug.Log(availableNumbers.Count);
            // Rastgele bir sayı seç
            int randomIndex = UnityEngine.Random.Range(0, availableNumbers.Count);
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
        void SaveProgress()
        {
            gameManager.story.currentCallCount = currentCallCountLocal;
            gameManager.story.timer = timerLocal;
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
        void LoadProgress()
        {
            currentCallCountLocal = gameManager.story.currentCallCount;
            timerLocal = gameManager.story.timer;
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
            SaveProgress();
        }
    }
}
