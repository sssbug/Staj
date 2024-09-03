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
        private float interval = 70;  // Her 20 saniyede bir çalışacak
        private int maxCalls;     // Fonksiyon toplamda 23 kere çalışacak
        
        private float timerLocal;
        public GameObject conversationManager;
        bool basla = true;
        bool bomba = false;
        private int[] gun = { 6, 8, 9, 14 };
        private int[] gun1 = { 2, 3, 4, 21 };
        private int[] gun2 = { 19, 11, 5, 17 };
        private int[] gun3 = { 2, 0, 13, 12 };
        private int[] gun4 = { 19, 10, 18, 7 };
        private int[] gun5 = { 1, 22, 2, 16 };
        private int[] gun6 = { 2, 9, 14, 4, 22 };

        private Animator shake;
        void Start()
        {
            shake = GameObject.Find("Zemin").GetComponent<Animator>();
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            // Save dosyasının yolunu belirleyin
            savePath = Path.Combine(Application.persistentDataPath, "generatedNumbers.json");

            // Önceden kaydedilmiş sayıları yükle
            //LoadGeneratedNumbers();
            LoadProgress(); // Uygulama açıldığında ilerlemeyi yükle
            if (gameManager.story.gun[0] == true)
            {
                maxCalls = gun.Length;
            }
            else if (gameManager.story.gun[1] == true)
            {
                maxCalls = gun1.Length;
            }
            else if (gameManager.story.gun[2] == true)
            {
                maxCalls = gun2.Length;
            }
            else if (gameManager.story.gun[3] == true)
            {
                maxCalls = gun3.Length;
            }
            else if (gameManager.story.gun[4] == true)
            {
                maxCalls = gun4.Length;
            }
            else if (gameManager.story.gun[5] == true)
            {
                maxCalls = gun5.Length;
            }
            else if (gameManager.story.gun[6] == true)
            {
                maxCalls = gun6.Length;
            }
            if (gameManager.story.currentCallCount < maxCalls)
            {
                timerLocal = interval - timerLocal; // Kaldığı yerden devam edebilmesi için kalan süreyi hesapla
            }
            if (gameManager.story.gun[6])
            {
                interval = 1;
            }
            else
            {
                interval = 70;
            }
        }


        void Update()
        {
            
            if (gameManager.story.gun[6] == true)
            {
                
                if (timerLocal >= 1 || timerLocal < 0)
                {
                    timerLocal = 1;
                }
            }
            else
            {
                
                if (timerLocal >= 70 || timerLocal < 0)
                {
                    timerLocal = 70;
                }
            }
            
            if (TimeManager.Instance.story.isTime == false)
            {

                if (gameManager.story.gun[0] == true)
                {
                    maxCalls = gun.Length;
                }
                else if (gameManager.story.gun[1] == true)
                {
                    maxCalls = gun1.Length;
                }
                else if (gameManager.story.gun[2] == true)
                {
                    maxCalls = gun2.Length;
                }
                else if (gameManager.story.gun[3] == true)
                {
                    maxCalls = gun3.Length;
                }
                else if (gameManager.story.gun[4] == true)
                {
                    maxCalls = gun4.Length;
                }
                else if (gameManager.story.gun[5] == true)
                {
                    maxCalls = gun5.Length;
                }
                else if (gameManager.story.gun[6] == true)
                {
                    maxCalls = gun6.Length;
                }
                gameManager.story.currentCallCount = 0;
                if (gameManager.story.currentCallCount < maxCalls)
                {
                    timerLocal = interval - timerLocal;
                }


                if (gameManager.story.gun[6])
                {
                    interval = 1;
                    
                }
                else
                {
                    interval = 70;
                }

                TimeManager.Instance.story.isTime = true;
            }

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


                if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) > 0.2 && (Math.Floor(TimeManager.Instance.timePercent * 10) / 10) < 0.7)
                {
                    if (gameManager.story.currentCallCount < maxCalls)
                    {
                        if (conversationManager.activeSelf == false)
                        {
                            timerLocal += Time.deltaTime;


                            if (timerLocal >= interval)
                            {

                                misafirSpawn();

                                gameManager.story.currentCallCount++;
                                timerLocal = 0f; 

                                SaveProgress();
                            }
                        }
                    }
                }
            }
            if (gameManager.story.gun[6] == true)
            {
                if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) == 0.3)
                {
                    if (GameObject.Find("Zemin").TryGetComponent<Animator>(out Animator ani))
                    {
                        shake.SetTrigger("shake");
                        Destroy(shake, shake.GetCurrentAnimatorStateInfo(0).length);
                    }

                }

            }
            if (gameManager.story.dialog3 == false)
            {
                if (gameManager.story.gun[4] == true)
                {
                    if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) == 0.2)
                    {
                        if (bomba == false)
                        {
                            ConversationManager.Instance.StartConversation(_myConvarsation);
                            ConversationManager.Instance.SetInt("story", 2);
                            bomba = true;
                        }

                    }
                }
            }
            if (gameManager.story.gunSayacı == 9)
            {
                if (gameManager.story.eşyalar == false)
                {
                    Inventory halı = new Inventory(gameManager, gameManager.inventoryItems[3], "Untagged");
                    Inventory halı2 = new Inventory(gameManager, gameManager.inventoryItems[4], "Untagged");
                    Inventory halı3 = new Inventory(gameManager, gameManager.inventoryItems[5], "Untagged");
                    Inventory halı4 = new Inventory(gameManager, gameManager.inventoryItems[6], "Untagged");
                    Inventory halı5 = new Inventory(gameManager, gameManager.inventoryItems[7], "Untagged");
                    gameManager.story.eşyalar = true;
                }

            }
        }


        public void bomb()
        {
            Inventory halı = new Inventory(gameManager, gameManager.inventoryItems[0],"bomb");
            gameManager.InventorySaveGame();
            gameManager.story.dialog3 = true;
        }
        public void misafirSpawn()
        {
            /*GenerateUniqueRandomNumber()*/
            if (gameManager.story.gun[0] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun[gameManager.story.generated]);
                gameManager.story.generated += 1;
            }
            else if (gameManager.story.gun[1] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun1[gameManager.story.generated1]);
                gameManager.story.generated1 += 1;
            }
            else if (gameManager.story.gun[2] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun2[gameManager.story.generated2]);
                gameManager.story.generated2 += 1;
            }
            else if (gameManager.story.gun[3] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun3[gameManager.story.generated3]);
                gameManager.story.generated3 += 1;
            }
            else if (gameManager.story.gun[4] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun4[gameManager.story.generated4]);
                gameManager.story.generated4 += 1;
            }
            else if (gameManager.story.gun[5] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun5[gameManager.story.generated5]);
                gameManager.story.generated5 += 1;
            }
            else if (gameManager.story.gun[6] == true)
            {
                CharacterSpawn characterSpawn = new CharacterSpawn(new Vector3(-2.72f, 0f, 0), gun6[gameManager.story.generated6]);
                gameManager.story.generated6 += 1;
            }
        }

        void SaveProgress()
        {
            
            gameManager.story.timer = timerLocal;
        }

        void LoadProgress()
        {
            
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
