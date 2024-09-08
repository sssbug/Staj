using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DS
{
    public class TimeManager : MonoBehaviour
    {
        public static TimeManager Instance { get; private set; }
        public float timePercent = 0f;
        public float speedFactor = 1f;
        [SerializeField]
        public odaVeriTabanı odaVeriTabanıı;
        [SerializeField]
        public Story story;
        private const string TimePercentKey = "TimePercent";
        private const string LastSavedTimeKey = "LastSavedTime";
        public int basla = 1;
        public int dokuz = 1;
        public int itiraf = 1;
        public bool isWork;
        
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
        }

        private void Start()
        {
            LoadTime();
            story.LoadStory();
            odaVeriTabanıı.LoadData();
        }

        private void Update()
        {

            if (isWork == false)
            {
                timePercent += (Time.deltaTime / (24f * 60f)) * speedFactor;
                if (timePercent >= 1f) timePercent = 0f;

                if ((Math.Floor(timePercent * 10) / 10) == 0)
                {
                    if (basla == 1)
                    {
                        odaVeriTabanıı.odalar();
                        story.gun[story.gunSayacı] = false;
                        story.gun[story.gunSayacı + 1] = true;
                        story.gunSayacı += 1;
                        basla = 0;
                        story.isTime = false;
                        
                        if (story.gunSayacı == 2)
                        {
                            if (story.globalGorev >= 1)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }
                            
                        }
                        else if (story.gunSayacı == 3)
                        {
                            if (story.globalGorev >= 1)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }

                        }
                        else if (story.gunSayacı == 5)
                        {
                            if (story.globalGorev >= 1)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }

                        }
                        else if (story.gunSayacı == 8)
                        {
                            if (story.globalGorev >= 5)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }

                        }
                        else if (story.gunSayacı == 9)
                        {
                            if (story.globalGorev >= 4)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }

                        }
                        else if (story.gunSayacı == 10)
                        {
                            if (story.globalGorev >= 3)
                            {
                                story.globalGorev = 0;
                            }
                            else
                            {
                                SceneManager.LoadScene("Scene3");
                            }

                        }
                        
                        

                    }

                }
                else
                {
                    basla = 1;
                }
                if ((Math.Floor(timePercent * 10) / 10) == 0.2)
                {
                    if (dokuz == 1)
                    {
                        story.ölümHaberi = false;
                        dokuz = 0;
                    }

                }
                if ((Math.Floor(timePercent * 10) / 10) == 0.3)
                {
                    if (itiraf == 1)
                    {
                        story.itiraf = false;
                        itiraf = 0;

                    }

                }
                if (story.gunSayacı == 10 && story.bitti == true)
                {
                    SceneManager.LoadScene("Scene4");
                }
            }
           

        }

        private void OnApplicationQuit()
        {
            SaveTime();
            story.SaveStory();
            odaVeriTabanıı.SaveData();
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus)
            {
                SaveTime();
                story.SaveStory();
                odaVeriTabanıı.SaveData();
            }
        }

        private void SaveTime()
        {
            PlayerPrefs.SetFloat(TimePercentKey, timePercent);
            PlayerPrefs.SetString(LastSavedTimeKey, DateTime.Now.ToBinary().ToString());
            PlayerPrefs.Save();
        }

        private void LoadTime()
        {
            if (PlayerPrefs.HasKey(TimePercentKey) && PlayerPrefs.HasKey(LastSavedTimeKey))
            {
                timePercent = PlayerPrefs.GetFloat(TimePercentKey);
                long temp = Convert.ToInt64(PlayerPrefs.GetString(LastSavedTimeKey));
                DateTime lastSavedTime = DateTime.FromBinary(temp);

                TimeSpan timeSinceLastSave = DateTime.Now - lastSavedTime;
                float minutesPassed = (float)timeSinceLastSave.TotalMinutes;
                float realMinutesInDay = 24f * 60f; // Gerçek dünyada bir günün toplam dakikası
                float scaledMinutesInDay = realMinutesInDay / speedFactor; // Ölçeklendirilmiş gün süresi
                float additionalTimePercent = (minutesPassed % scaledMinutesInDay) / scaledMinutesInDay;

                timePercent += additionalTimePercent;
                if (timePercent >= 1f) timePercent -= 1f;
            }
            else
            {
                // Eğer anahtarlar yoksa zaman yüzdesini hesapla
                DateTime currentTime = DateTime.Now;
                float realMinutesInDay = 24f * 60f; // Gerçek dünyada bir günün toplam dakikası
                float scaledMinutesInDay = realMinutesInDay / speedFactor; // Ölçeklendirilmiş gün süresi
                float currentMinutes = currentTime.Hour * 60f + currentTime.Minute + currentTime.Second / 60f;
                timePercent = (currentMinutes % scaledMinutesInDay) / scaledMinutesInDay;
            }
        }
    }
}
