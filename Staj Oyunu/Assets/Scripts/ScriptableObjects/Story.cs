
using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace DS
{
    [CreateAssetMenu(fileName = "Story", menuName = "Persistence")]
    public class Story : ScriptableObject
    {
        public bool Play;
        public int[] dialogSayac;
        public int para;
        public bool müşteriBasla;
        public bool basla;

        public List<bool> isRun = new List<bool>(new bool[22]);

        public int sira;
        public int gunSayacı;
        public int globalGorev;
        public int sorgulama;
        public bool bitti = false;
        public List<string> loadedInventoryItemNames;
        public bool sil;

        public int dokuzuncuGün;
        public bool ölümHaberi;
        public bool itiraf;
        public bool eşyalar;



        public bool[] gun;
        public int generated;
        public int generated1;
        public int generated2;
        public int generated3;
        public int generated4;
        public int generated5;
        public int generated6;


        //burası liste olabilir ama değil
        public bool dialog1;
        public int currentCallCount;
        public bool isTime = true;
        public float timer;
        public bool dialog2;
        public bool dialog3;
        public bool dialog4;
        public bool dialog5;
        public bool dialog6;
        public bool dialog7;
        public bool dialog8;
        public bool dialog9;
        public bool dialog10;
        public bool dialog11;
        public bool dialog12;
        public bool dialog13;
        public bool dialog14;
        public bool dialog15;
        public bool dialog16;
        public bool dialog17;
        public bool dialog18;
        public bool dialog19;
        public bool dialog20;
        public bool dialog21;
        public bool dialog22;
        public bool dialog23;
        public bool dialog24;
        public bool dialog25;
        public bool dialog26;
        public bool dialog27;
        public bool dialog28;
        private string filePath;
        public void SaveStory()
        {
            filePath = Application.persistentDataPath + "/storyData.json";

            // ScriptableObject'i JSON formatına dönüştür
            string jsonData = JsonUtility.ToJson(this);
            File.WriteAllText(filePath, jsonData);
            Debug.Log("Veriler kaydedildi: " + filePath);
        }

        // JSON formatındaki verileri geri yüklemek için bir method
        public void LoadStory()
        {
            filePath = Application.persistentDataPath + "/storyData.json";

            if (File.Exists(filePath))
            {
                // Dosyadan JSON verisini oku
                string jsonData = File.ReadAllText(filePath);
                // JSON verisini mevcut ScriptableObject'e uygula
                JsonUtility.FromJsonOverwrite(jsonData, this);
                Debug.Log("Veriler yüklendi.");
            }
            else
            {
                Debug.LogWarning("Kayıt dosyası bulunamadı!");
            }
        }
        public void ResetData()
        {
            Play = true;
            dialogSayac = new int[40]; // 40 elemanlı bir dizi olarak sıfırlanır
            para = 0;
            müşteriBasla = false;
            basla = false;

            sira = 0;
            gunSayacı = 0;
            globalGorev = 0;
            sorgulama = 0;
            bitti = false;
            loadedInventoryItemNames = new List<string>(new string[40]); // 40 elemanlı bir liste olarak sıfırlanır
            sil = false;

            dokuzuncuGün = 0;
            ölümHaberi = false;
            itiraf = false;
            eşyalar = false;
            isRun = new List<bool>(new bool[22]);
            gun = new bool[40];
            gun[0] = true;
            generated = 0;
            generated1 = 0;
            generated2 = 0;
            generated3 = 0;
            generated4 = 0;
            generated5 = 0;
            generated6 = 0;

            dialog1 = false;
            currentCallCount = 0;
            isTime = true;
            timer = 0f;

            dialog2 = false;
            dialog3 = false;
            dialog4 = false;
            dialog5 = false;
            dialog6 = false;
            dialog7 = false;
            dialog8 = false;
            dialog9 = false;
            dialog10 = false;
            dialog11 = false;
            dialog12 = false;
            dialog13 = false;
            dialog14 = false;
            dialog15 = false;
            dialog16 = false;
            dialog17 = false;
            dialog18 = false;
            dialog19 = false;
            dialog20 = false;
            dialog21 = false;
            dialog22 = false;
            dialog23 = false;
            dialog24 = false;
            dialog25 = false;
            dialog26 = false;
            dialog27 = false;
            dialog28 = false;
        }
    }
}
