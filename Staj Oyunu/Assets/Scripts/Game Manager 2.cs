using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace DS
{
    public class GameManager2 : MonoBehaviour
    {
        [SerializeField]
        public odaVeriTabanı odaVeriTabanıı;
        [SerializeField]
        public Story story;
        public GameObject liftButton;
        public List<GameObject> odalar = new List<GameObject>();
        public List<GameObject> Characters = new List<GameObject>();
        private bool[] temizlikYapıldıMı = new bool[33];
        public bool isLiftOut = false;
        public bool isLiftOut1 = false;
        public bool isLiftOut2 = false;
        public bool isLiftOut3 = false;
        public bool isLiftOut4 = false;
        public bool isLifter = true;
        public Light2D gunes;
        public GameObject temizlikMalzemesi;
        public List<GameObject> lamba = new List<GameObject>();
        int basla = 1;
        public GameObject conversationManager;
        public List<Sprite> sprites = new List<Sprite>();



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
            for (int i = 1; i < odalar.Count; i++)
            {
                if (temizlikYapıldıMı[i] == false)
                {
                    if (odaVeriTabanıı.temizlikOdalar[i] == true)
                    {

                        GameObject spawn = Instantiate(temizlikMalzemesi, odalar[i].transform.position + new Vector3(-1, 3, 0), Quaternion.identity);
                        spawn.transform.parent = odalar[i].transform;


                    }
                    temizlikYapıldıMı[i] = true;
                }

            }
            if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) == 0.1)
            {
                if (basla == 1)
                {
                    for (int i = 0; i < odalar.Count; i++)
                    {
                        temizlikYapıldıMı[i] = false;
                    }
                    basla = 0;
                }

            }
            if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) == 0.2)
            {
                basla = 1;
            }
            if ((Math.Floor(TimeManager.Instance.timePercent * 10) / 10) < 0.8 && (Math.Floor(TimeManager.Instance.timePercent * 10) / 10) > 0.1)
            {
                for (int i = 0; i < lamba.Count; i++)
                {
                    lamba[i].SetActive(false);
                }
            }
            else
            {
                for (int i = 0; i < lamba.Count; i++)
                {
                    lamba[i].SetActive(true);
                }
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
    }
}
