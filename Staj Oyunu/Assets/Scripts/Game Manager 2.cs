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
        public GameObject liftButton;
        public GameObject temilik;
        public bool isLiftOut = false;
        public bool isLiftOut1 = false;
        public bool isLiftOut2 = false;
        public bool isLiftOut3 = false;
        public bool isLiftOut4 = false;
        public bool isLifter = true;
        public Light2D gunes;
        public List<GameObject> odalar = new List<GameObject>();
        private bool[] temizlikYapıldıMı = new bool[32];
        

        private void Update()
        {
            float timePercent = TimeManager.Instance.timePercent;

            UpdateLighting(timePercent);

            for (int i = 0; i < odalar.Count; i++)
            {
                if (temizlikYapıldıMı[i] == false)
                {
                    if (odaVeriTabanıı.temizlikOdalar[i] == true)
                    {

                        GameObject spawn = Instantiate(temilik, odalar[i].transform.position + new Vector3(-1,3,0), Quaternion.identity);
                        spawn.transform.parent = odalar[i].transform;
                        


                    }
                    temizlikYapıldıMı[i] = true;
                }
                
            }
            if (Mathf.Round(timePercent) == 0)
            {
                for (int i = 0; i < odalar.Count; i++)
                {
                    temizlikYapıldıMı[i] = false;
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
