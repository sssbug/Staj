using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
namespace DS
{
    //new Vector2(-110.886909f, 1271.63879f)
    
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        public odaVeriTabanı odaVeriTabanıı;
        [SerializeField]
        public Story story;
        public List<string> charactersPrefabNames;
        public List<GameObject> charactersPrefab = new List<GameObject>();
        public List<GameObject> characters = new List<GameObject>();
        public List<GameObject> charactersBackPrefab = new List<GameObject>();
        public List<GameObject> charactersBack = new List<GameObject>();
        public List<GameObject> charactersReversePrefab = new List<GameObject>();
        public List<GameObject> inventory = new List<GameObject>();
        public GameObject slot;

        public List<string> loadedCharactersNames;
        public List<string> loadedCharactersBackPrefabNames;
        public List<string> loadedCharactersBackNames;
        public List<string> loadedCharactersReversePrefabNames;
        public List<string> loadedInventoryItemNames;
        public List<string> loadedOtelinSahibiNames;
        

        public List<GameObject> inventoryItems = new List<GameObject>();
        public List<GameObject> Notlar = new List<GameObject>();
        public List<GameObject> otelinSahibi = new List<GameObject>();
        public GameObject lamba;
        public GameObject keys;
        public GameObject InventoryObject;
        public GameObject sıradaki;
        public int sıradakiCount;
        public int spawnlanacak;
        public int sayac;
        public Light2D gunes;

        public GameObject conversationManager;

        private List<string> destroyedObjects = new List<string>();
        private string destroySavePath;
        private GameObject _myObject;

        public float dayDuration = 24f; // Bir günün kaç saniye süreceği

        private float currentTimeOfDay = 0f;

        private string savePath;
        private string itemSavePath;
        

        private void Start()
        {

            
            savePath = Path.Combine(Application.persistentDataPath, "gameData.json");
            itemSavePath = Path.Combine(Application.persistentDataPath, "itemData.json");
            destroySavePath = Path.Combine(Application.persistentDataPath, "destroyedObjects.json");
            LoadDestroyedObjects();
            RemoveDestroyedObjectsFromScene();
            
            
            InventoryLoadGame();
        }
       

        private void Update()
        {
            
            float timePercent = TimeManager.Instance.timePercent;
            if (conversationManager.activeSelf == false)
            {
                TimeManager.Instance.isWork = false;
            }
            else
            {
                TimeManager.Instance.isWork = true;
            }
            UpdateLighting(timePercent);

            if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) < 0.8 && (Math.Floor(TimeManager.Instance.timePercent * 10) / 10) > 0.1)
            {

                lamba.SetActive(false);

            }
            else
            {

                lamba.SetActive(true);

            }
            
        }
        void UpdateLighting(float timePercent)
        {
            // Işığın rengini ve yoğunluğunu gün içindeki zaman yüzdesine göre ayarla
            if (timePercent <= 0.25f) // Sabah (Gün Doğumu)
            {
                gunes.intensity = Mathf.Lerp(0.1f, 1f, timePercent / 0.25f);
                gunes.color = Color.Lerp(new Color(0.1f, 0.1f, 0.4f), new Color(1f, 0.95f, 0.8f), timePercent / 0.25f);
            }
            else if (timePercent <= 0.75f) // Öğlen (Gündüz)
            {
                gunes.intensity = 1f;
                gunes.color = new Color(1f, 0.95f, 0.8f);
            }
            else // Akşam (Gün Batımı) ve Gece
            {
                gunes.intensity = Mathf.Lerp(1f, 0.1f, (timePercent - 0.75f) / 0.25f);
                gunes.color = Color.Lerp(new Color(1f, 0.95f, 0.8f), new Color(0.1f, 0.1f, 0.4f), (timePercent - 0.75f) / 0.25f);
            }
        }


        public void cikis()
        {
            string[] ismi = sıradaki.name.Split("(Clone)");
            for (int i = 0; i < charactersBackPrefab.Count; i++)
            {
                if (charactersBackPrefab[i].name == ismi[0])
                {
                    spawnlanacak = i;
                    GameObject spawn = Instantiate(charactersReversePrefab[i], sıradaki.transform.position, Quaternion.identity);

                    spawn.transform.parent = GameObject.Find("Canvas").transform;
                    charactersBack.Remove(sıradaki);
                    if (sıradaki.name == "Misafirlerb23(Clone)")
                    {
                        story.dialog5 = false;
                    }
                    Destroy(sıradaki);
                    sıradaki = null;
                }
            }





        }



        public void sahne2() 
        {
            SaveGame();
            SaveDestroyedObjects();
            InventorySaveGame();
            SceneManager.LoadScene("Scene2"); 
        }


        public void SaveGame()
        {
            GameData data = new GameData();



            // Karakter isimlerini kaydet
            data.charactersNames = new List<string>();
            foreach (var character in characters)
            {
                data.charactersNames.Add(character.name.Replace("(Clone)", "").Trim());
            }



            // Arka plan karakter isimlerini kaydet
            data.charactersBackNames = new List<string>();
            foreach (var character in charactersBack)
            {
                data.charactersBackNames.Add(character.name.Replace("(Clone)", "").Trim());


            }


            data.spawnedharactersPrefabNames = new List<string>();
            foreach (var character in charactersPrefabNames)
            {
                data.spawnedharactersPrefabNames.Add(character.Replace("(Clone)", "").Trim());


            }






            // Veriyi JSON formatına dönüştür ve dosyaya yaz
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(savePath, json);
        }
        public void InventorySaveGame()
        {
            InventoryData data = new InventoryData();



            // Karakter isimlerini kaydet
            data.itemsName = new List<string>();
            foreach (var items in inventory)
            {
                data.itemsName.Add(items.name.Replace("(Clone)", "").Trim());
            }


            // Veriyi JSON formatına dönüştür ve dosyaya yaz
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(itemSavePath, json);
        }
        public void InventoryLoadGame()
        {
            if (File.Exists(itemSavePath))
            {
                string json = File.ReadAllText(itemSavePath);
                InventoryData data = JsonUtility.FromJson<InventoryData>(json);

                // JSON'dan gelen verileri public listelere kaydet
                loadedInventoryItemNames = data.itemsName;
                if (story.sil == true)
                {
                    loadedInventoryItemNames.RemoveAt(0);
                }
                foreach (var item in inventoryItems)
                {
                    if (loadedInventoryItemNames.Contains(item.name) )
                    {
                        _myObject = Instantiate(item);
                        _myObject.transform.rotation = Quaternion.identity;
                       inventory.Add(_myObject);
                    }
                }


            }
        }
        public void InventoryAc()
        {
            if (InventoryObject.activeSelf == false)
            {
                InventoryObject.SetActive(true);
                
            }
            else
            {
                InventoryObject.SetActive(false);
                
            }
            
        }
        public void LoadGame()
        {
            if (File.Exists(savePath))
            {
                string json = File.ReadAllText(savePath);
                GameData data = JsonUtility.FromJson<GameData>(json);

                // JSON'dan gelen verileri public listelere kaydet
                loadedCharactersNames = data.charactersNames;
                loadedCharactersBackNames = data.charactersBackNames;
                charactersPrefabNames = data.spawnedharactersPrefabNames;


            }
        }

        public void RegisterDestroyedObject(string objectName)
        {
            // Obje ismini listeye ekle
            if (!destroyedObjects.Contains(objectName))
            {
                destroyedObjects.Add(objectName);
                SaveDestroyedObjects();
            }
        }

        private void SaveDestroyedObjects()
        {
            // Listeyi JSON formatında kaydet
            string json = JsonUtility.ToJson(new SerializableListt<string>(destroyedObjects), true);
            File.WriteAllText(destroySavePath, json);
            Debug.Log("Destroyed objects saved to " + destroySavePath);
        }
        private void RemoveDestroyedObjectsFromScene()
        {
            foreach (string objectName in destroyedObjects)
            {
                GameObject obj = GameObject.Find(objectName);
                if (obj != null)
                {
                    Destroy(obj);
                }
            }
        }
        private void LoadDestroyedObjects()
        {
            if (File.Exists(destroySavePath))
            {
                string json = File.ReadAllText(destroySavePath);
                SerializableListt<string> data = JsonUtility.FromJson<SerializableListt<string>>(json);
                destroyedObjects = data.List;
                Debug.Log("Destroyed objects loaded from " + destroySavePath);
            }
            else
            {
                Debug.LogWarning("Save file not found at " + destroySavePath);
            }
        }
    }



    [System.Serializable]
    public class SerializableListt<T>
    {
        public List<T> List;

        public SerializableListt(List<T> list)
        {
            List = list;
        }
    }



}

