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
        public bool isRun;

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

            if (missionContainer != null)
            {

                if (story.gunSayacı == 0 && story.globalGorev == 0)
                {
                    if (story.isRun[0] == false)
                    {

                        GorevEkle(0);
                        story.isRun[0] = true;
                    }

                }
                else if (story.gunSayacı == 1 && story.globalGorev == 0)
                {
                    if (story.isRun[1] == false)
                    {
                        GorevEkle(1);
                        story.isRun[1] = true;
                    }

                }
                else if (story.gunSayacı == 2 && story.globalGorev == 0)
                {
                    if (story.isRun[2] == false)
                    {
                        GorevSil(1,1);
                        GorevEkle(2);
                        story.isRun[2] = true;
                    }

                }
                else if (story.gunSayacı == 3 && story.globalGorev == 0)
                {
                    if (story.isRun[23] == false)
                    {
                        GorevSil(1,2);

                        story.isRun[23] = true;
                    }

                }
                else if (story.gunSayacı == 4 && story.globalGorev == 0)
                {
                    if (story.isRun[3] == false)
                    {
                        
                        GorevEkle(3);
                        story.isRun[3] = true;
                    }

                }
                else if (story.gunSayacı == 5 && story.globalGorev == 0)
                {
                    if (story.isRun[22] == false)
                    {
                        GorevSil(1,3);
                        story.isRun[22] = true;
                    }

                }
                else if (story.gunSayacı == 6 && story.globalGorev == 0)
                {
                    if (story.isRun[4] == false)
                    {
                        
                        GorevSil(0,0);
                        GorevEkle(4);
                        story.isRun[4] = true;
                    }

                }
                else if (story.gunSayacı == 7 && story.globalGorev == 0)
                {
                    if (story.isRun[5] == false)
                    {
                        GorevSil(0,4);
                        GorevEkle(5);
                        story.isRun[5] = true;
                    }

                }
                else if (story.gunSayacı == 7 && story.globalGorev == 1)
                {
                    if (story.isRun[6] == false)
                    {
                        GorevSil(0,5);
                        GorevEkle(6);
                        story.isRun[6] = true;
                    }

                }
                else if (story.gunSayacı == 7 && story.globalGorev == 2)
                {
                    if (story.isRun[7] == false)
                    {
                        GorevSil(0,6);
                        GorevEkle(7);
                        story.isRun[7] = true;
                    }

                }
                else if (story.gunSayacı == 7 && story.globalGorev == 3)
                {
                    if (story.isRun[8] == false)
                    {
                        GorevSil(0,7);
                        GorevEkle(8);
                        story.isRun[8] = true;
                    }

                }
                else if (story.gunSayacı == 7 && story.globalGorev == 4)
                {
                    if (story.isRun[9] == false)
                    {
                        GorevSil(0,8);
                        GorevEkle(9);
                        story.isRun[9] = true;
                    }


                }
                else if (story.gunSayacı == 8 && story.globalGorev == 0)
                {
                    if (story.isRun[10] == false)
                    {
                        GorevSil(0,9);
                        GorevEkle(10);
                        story.isRun[10] = true;
                    }

                }
                else if (story.gunSayacı == 8 && story.globalGorev == 1)
                {
                    if (story.isRun[11] == false)
                    {
                        GorevSil(0,10);
                        GorevEkle(11);
                        story.isRun[11] = true;
                    }

                }
                else if (story.gunSayacı == 8 && story.gunSayacı == 2)
                {
                    if (story.isRun[12] == false)
                    {
                        GorevSil(0,11);
                        GorevEkle(12);
                        story.isRun[12] = true;
                    }

                }
                else if (story.gunSayacı == 8 && story.sorgulama == 3)
                {
                    if (story.isRun[13] == false)
                    {
                        GorevSil(0,12);
                        GorevEkle(13);
                        story.isRun[13] = true;
                    }

                }
                else if (story.gunSayacı == 9 && story.globalGorev == 1)
                {
                    if (story.isRun[14] == false)
                    {
                        GorevSil(0,13);
                        GorevEkle(14);
                        story.isRun[14] = true;
                    }

                }
                else if (story.gunSayacı == 9 && story.globalGorev == 2)
                {
                    if (story.isRun[15] == false)
                    {
                        GorevSil(0,14);
                        GorevEkle(15);
                        story.isRun[15] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 0)
                {
                    if (story.isRun[16] == false)
                    {
                        GorevSil(0,15);
                        GorevEkle(16);
                        story.isRun[16] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 1)
                {
                    if (story.isRun[17] == false)
                    {
                        GorevSil(0,16);
                        GorevEkle(17);
                        story.isRun[17] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 2)
                {
                    if (story.isRun[18] == false)
                    {
                        GorevSil(0,17);
                        GorevEkle(18);
                        story.isRun[18] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 3)
                {
                    if (story.isRun[19] == false)
                    {
                        GorevSil(0,18);
                        GorevEkle(19);
                        story.isRun[19] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 4)
                {
                    if (story.isRun[20] == false)
                    {
                        GorevSil(0,19);
                        GorevEkle(20);
                        story.isRun[20] = true;
                    }

                }
                else if (story.gunSayacı == 10 && story.globalGorev == 5)
                {
                    if (story.isRun[21] == false)
                    {
                        GorevSil(0,20);
                        GorevEkle(21);
                        story.isRun[21] = true;
                    }

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
        public void GorevSil(int görevId, int gorev)
        {
            // Find and remove the task from the taskData list
            
            TaskData taskToRemove = taskData.Find(task => task.görevId == gorev);
            if (taskToRemove != null)
            {
                taskData.Remove(taskToRemove);

                // Remove the corresponding UI element
                foreach (Transform child in missionContainer.transform)
                {
                    TextMeshProUGUI textComponent = child.GetComponentInChildren<TextMeshProUGUI>();
                    if (textComponent != null && textComponent.text == tasks[gorev])
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
