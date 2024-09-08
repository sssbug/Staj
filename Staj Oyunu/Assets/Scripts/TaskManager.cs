using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;


namespace DS
{
    [System.Serializable]
    public class TaskData
    {
        public int görevId;  // Serileştirilebilir int değer
        public string görevMetin;  // Serileştirilebilir string değer
    }
 
    public class TaskManager : MonoBehaviour
    {
        public static TaskManager Instance { get; private set; }
        public List<string> tasks = new List<string>();
        public List<TaskData> taskData = new List<TaskData>();
        public GameObject prefab;
        public GameObject missionContainer;
        public Story story;
        public bool taskBasla;
        private string saveFilePath;
        public List<bool> isRun = new List<bool>(new bool[22]);
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            saveFilePath = Application.persistentDataPath + "/tasks.json";
        }
        private void Update()
        {
            if (taskBasla == true)
            {
                LoadTasks();
                taskBasla = false;
            }

            if (story.gunSayacı == 0 && story.globalGorev == 0)
            {
                if (isRun[0] == false)
                {

                    GorevEkle(0);
                    isRun[0] = true;
                }
                
            }
            else if (story.gunSayacı == 1 && story.globalGorev == 0)
            {
                if (isRun[1] == false)
                {
                    GorevEkle(1);
                    isRun[1] = true;
                }
                
            }
            else if (story.gunSayacı == 2 && story.globalGorev == 0)
            {
                if (isRun[2] == false)
                {
                    GorevSil(1);
                    GorevEkle(2);
                    isRun[2] = true;
                }
                
            }
            else if (story.gunSayacı == 4 && story.globalGorev == 0)
            {
                if (isRun[3] == false)
                {
                    GorevSil(1);
                    GorevEkle(3);
                    isRun[3] = true;
                }
                
            }
            else if (story.gunSayacı == 6 && story.globalGorev == 0)
            {
                if (isRun[4] == false)
                {
                    GorevSil(1);
                    GorevSil(0);
                    GorevEkle(4);
                    isRun[4] = true;
                }
                
            }
            else if (story.gunSayacı == 7 && story.globalGorev == 0)
            {
                if (isRun[5] == false)
                {
                    GorevSil(0);
                    GorevEkle(5);
                    isRun[5] = true;
                }
                
            }
            else if (story.gunSayacı == 7 && story.globalGorev == 1)
            {
                if (isRun[6] == false)
                {
                    GorevSil(0);
                    GorevEkle(6);
                    isRun[6] = true;
                }
                
            }
            else if (story.gunSayacı == 7 && story.globalGorev == 2)
            {
                if (isRun[7] == false)
                {
                    GorevSil(0);
                    GorevEkle(7);
                    isRun[7] = true;
                }
                 
            }
            else if (story.gunSayacı == 7 && story.globalGorev == 3)
            {
                if (isRun[8] == false)
                {
                    GorevSil(0);
                    GorevEkle(8);
                    isRun[8] = true;
                }
                
            }
            else if (story.gunSayacı == 7 && story.globalGorev == 4)
            {
                if (isRun[9] == false)
                {
                    GorevSil(0);
                    GorevEkle(9);
                    isRun[9] = true;
                }
                

            }
            else if (story.gunSayacı == 8 && story.globalGorev == 0)
            {
                if (isRun[10] == false)
                {
                    GorevSil(0);
                    GorevEkle(10);
                    isRun[10] = true;
                }
                
            }
            else if (story.gunSayacı == 8 && story.globalGorev == 1)
            {
                if (isRun[11] == false)
                {
                    GorevSil(0);
                    GorevEkle(11);
                    isRun[11] = true;
                }
                 
            }
            else if (story.gunSayacı == 8 && story.sorgulama == 2)
            {
                if (isRun[12] == false)
                {
                    GorevSil(0);
                    GorevEkle(12);
                    isRun[12] = true;
                }
                
            }
            else if (story.gunSayacı == 8 && story.globalGorev == 3)
            {
                if (isRun[13] == false)
                {
                    GorevSil(0);
                    GorevEkle(13);
                    isRun[13] = true;
                }
                
            }
            else if (story.gunSayacı == 9 && story.globalGorev == 1)
            {
                if (isRun[14] == false)
                {
                    GorevSil(0);
                    GorevEkle(14);
                    isRun[14] = true;
                }
                 
            }
            else if (story.gunSayacı == 9 && story.globalGorev == 2)
            {
                if (isRun[15] == false)
                {
                    GorevSil(0);
                    GorevEkle(15);
                    isRun[15] = true;
                }
                
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 0)
            {
                if (isRun[16] == false)
                {
                    GorevSil(0);
                    GorevEkle(16);
                    isRun[16] = true;
                }
                
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 1)
            {
                if (isRun[17] == false)
                {
                    GorevSil(0);
                    GorevEkle(17);
                    isRun[17] = true;
                }
                 
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 2)
            {
                if (isRun[18] == false)
                {
                    GorevSil(0);
                    GorevEkle(18);
                    isRun[18] = true;
                }
                 
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 3)
            {
                if (isRun[19] == false)
                {
                    GorevSil(0);
                    GorevEkle(19);
                    isRun[19] = true;
                }
                
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 4)
            {
                if (isRun[20] == false)
                {
                    GorevSil(0);
                    GorevEkle(20);
                    isRun[20] = true;
                }
                
            }
            else if (story.gunSayacı == 10 && story.globalGorev == 5)
            {
                if (isRun[21] == false)
                {
                    GorevSil(0);
                    GorevEkle(21);
                    isRun[21] = true;
                }
                
            }














        }

        public void GorevEkle(int görevId)
        {
            // Instantiate and set up the task UI element
            GameObject yeniGorevSatiri = Instantiate(prefab);
            TextMeshProUGUI gorevText = yeniGorevSatiri.GetComponentInChildren<TextMeshProUGUI>();
            gorevText.text = tasks[görevId];
            yeniGorevSatiri.transform.parent = missionContainer.transform;

            // Add to taskData for saving
            TaskData newTask = new TaskData { görevId = görevId, görevMetin = tasks[görevId] };
            taskData.Add(newTask);

            SaveTasks();
        }
        public void GorevSil(int görevId)
        {
            // Find and remove the task from the taskData list
            TaskData taskToRemove = taskData.Find(task => task.görevId == görevId);
            if (taskToRemove != null)
            {
                taskData.Remove(taskToRemove);

                // Remove the corresponding UI element
                foreach (Transform child in missionContainer.transform)
                {
                    TextMeshProUGUI textComponent = child.GetComponentInChildren<TextMeshProUGUI>();
                    if (textComponent != null && textComponent.text == tasks[görevId])
                    {
                        Destroy(child.gameObject);
                        break;
                    }
                }

                SaveTasks();
            }
        }
        private void SaveTasks()
        {
            // Serialize taskData to JSON
            string json = JsonUtility.ToJson(new TaskListWrapper { tasklar = taskData });
            File.WriteAllText(saveFilePath, json);
        }

        private void LoadTasks()
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                TaskListWrapper wrapper = JsonUtility.FromJson<TaskListWrapper>(json);
                taskData = wrapper.tasklar;

                // Instantiate tasks UI elements
                foreach (TaskData task in taskData)
                {
                    GameObject yeniGorevSatiri = Instantiate(prefab);
                    TextMeshProUGUI gorevText = yeniGorevSatiri.GetComponentInChildren<TextMeshProUGUI>();
                    gorevText.text = task.görevMetin;
                    yeniGorevSatiri.transform.parent = missionContainer.transform;
                }
            }
        }

        [System.Serializable]
        private class TaskListWrapper
        {
            public List<TaskData> tasklar;
        }
    }
    
}
