
using System;
using UnityEngine;


namespace DS
{
    [CreateAssetMenu(fileName = "odaVeriTabanı", menuName = "Persistence")]
    public class odaVeriTabanı : ScriptableObject
    {
        public string isim;
        public int gün;
        public int oda;

        public int storyCount;

        public string[] isimdata = new string[40];

        public int[] gündata = new int[40];

        public int[] odadata = new int[40];

        public bool[] temizlikOdalar = new bool[40];


        public void odaData()
        {
            if (isim != null && oda != 0 && gün != 0)
            {

                isimdata[oda] = isim;
                gündata[oda] = gün;
                odadata[oda] = oda;

                isim = null;
                oda = 0;
                gün = 0;
            }
            else
            {
                Debug.Log("hata");
            }

        }
        public void odalar()
        {


            Debug.Log("odaveritabanı");
            for (int i = 0; i < odadata.Length; i++)
            {
                if (gündata[i] != 0)
                {
                    Debug.Log(isimdata[i]);

                    
                    gündata[i] = gündata[i] - 1;
                    temizlikOdalar[i] = true;
                    if (gündata[i] == 0)
                    {
                        isimdata[i] = null;
                        gündata[i] = 0;
                        odadata[i] = 0;

                    }
                }

            }
            
        }

        public void ResetData()
        {
            isim = "";
            gün = 0;
            oda = 0;
            storyCount = 0;

            for (int i = 0; i < 40; i++)
            {
                isimdata[i] = "";
                gündata[i] = 0;
                odadata[i] = 0;
                temizlikOdalar[i] = false;
            }
            isimdata[25] = "Misafirlerb25";
            gündata[25] = 100;
            odadata[25] = 25;
        }
    }
}
