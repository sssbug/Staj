using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    using UnityEngine;
    using System.Collections.Generic;
    using System.IO;

    public class ObjectManager : MonoBehaviour
    {
        public List<GameObject> prefabs; // Bu sahnede kullanılabilecek prefabların listesi
        private List<LayeredObjectData> layeredObjectsData = new List<LayeredObjectData>();
        private string savePath;
        private string _savePath;
        GameManager gameManager;
        private void Start()
        {
            savePath = Path.Combine(Application.persistentDataPath, "layeredObjects.json");
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        public void SaveObjects()
        {
            layeredObjectsData.Clear();

            // Sahnedeki tüm objeleri döneriz ve sadece layer 6 olanları kaydederiz
            foreach (GameObject obj in FindObjectsOfType<GameObject>())
            {
                if (obj.layer == 6)
                {
                    string prefabName = obj.name.Replace("(Clone)", "").Trim();
                    LayeredObjectData data = new LayeredObjectData(obj.transform.position, obj.transform.rotation, prefabName);
                    layeredObjectsData.Add(data);
                }
            }

            // Verileri JSON olarak serileştirip kaydet
            string json = JsonUtility.ToJson(new SerializableList<LayeredObjectData>(layeredObjectsData));
            File.WriteAllText(savePath, json);
        }

        public void LoadObjects()
        {
            if (File.Exists(savePath))
            {
                
                
                string json = File.ReadAllText(savePath);
                SerializableList<LayeredObjectData> dataList = JsonUtility.FromJson<SerializableList<LayeredObjectData>>(json);

                foreach (LayeredObjectData data in dataList.items)
                {
                    GameObject prefab = prefabs.Find(p => p.name == data.prefabName);
                    if (prefab != null)
                    {
                        if (gameManager.loadedCharactersNames.Contains(prefab.name))
                        {
                            GameObject obj = Instantiate(prefab, data.position, data.rotation);
                            gameManager.characters.Add(obj);
                            obj.transform.parent = GameObject.Find("Canvas").transform;
                            obj.layer = 6;
                        }
                        else if (gameManager.loadedCharactersBackNames.Contains(prefab.name))
                        {
                            GameObject obj = Instantiate(prefab, data.position, data.rotation);
                            gameManager.charactersBack.Add(obj);
                            obj.transform.parent = GameObject.Find("Canvas").transform;
                            obj.layer = 6;
                        }

                    }
                }
            }
        }
    }

    [System.Serializable]
    public class SerializableList<T>
    {
        public List<T> items;
        public SerializableList(List<T> items) { this.items = items; }
    }
}
