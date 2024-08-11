﻿using System;
using System.Collections;
using System.Collections.Generic;
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
        public List<GameObject> charactersPrefab = new List<GameObject>();
        public List<GameObject> characters = new List<GameObject>();
        public List<GameObject> charactersBackPrefab = new List<GameObject>();
        public List<GameObject> charactersBack = new List<GameObject>();
        public List<GameObject> charactersReversePrefab = new List<GameObject>();

        public List<GameObject> inventoryItems = new List<GameObject>();
        public List<GameObject> otelinSahibi = new List<GameObject>();
        public GameObject lamba;
        public GameObject keys;

        public GameObject sıradaki;
        public int spawnlanacak;
        public Light2D gunes;







        public float dayDuration = 24f; // Bir günün kaç saniye süreceği

        private float currentTimeOfDay = 0f;

        private void Start()
        {
            
        }


        private void Update()
        {
            float timePercent = TimeManager.Instance.timePercent;

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
                    Destroy(sıradaki);
                }
            }





        }



        public void sahne2() { SceneManager.LoadScene("Scene2"); }
        
    }
}
