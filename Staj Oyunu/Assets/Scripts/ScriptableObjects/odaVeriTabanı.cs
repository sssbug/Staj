
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
            
            if (Math.Round(TimeManager.Instance.timePercent) == 1f)
            {
                
                for (int i = 0; i < odadata.Length; i++)
                {
                    if (gündata[i] != 0)
                    {
                        Debug.Log(isimdata[i]);


                        gündata[i] = -1;
                        if (gündata[i] == 0)
                        {
                            isimdata[i] = null;
                            gündata[i] = 0;
                            odadata[i] = 0;
                            temizlikOdalar[i] = true;
                            
                        }
                    }
                    
                }
            }
            
        }
    }
}
