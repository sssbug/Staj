using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        private int gunSayacı = 0;
        private GameObject conversationManager;
        private void Awake()
        {

            conversationManager = GameObject.Find("Panel_Dialogue").gameObject;
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
        }

        private void Update()
        {
            if (conversationManager.activeSelf == false)
            {
                timePercent += (Time.deltaTime / (24f * 60f)) * speedFactor;
                if (timePercent >= 1f) timePercent = 0f;

                if ((Math.Floor(timePercent * 10) / 10) == 0)
                {
                    if (basla == 1)
                    {
                        odaVeriTabanıı.odalar();
                        story.gun[gunSayacı] = false;
                        story.gun[gunSayacı + 1] = true;
                        gunSayacı += 1;
                        basla = 0;
                    }

                }
                else
                {
                    basla = 1;
                }
            }
            
            
        }

        private void OnApplicationQuit()
        {
            SaveTime();
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            if (pauseStatus)
            {
                SaveTime();
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
