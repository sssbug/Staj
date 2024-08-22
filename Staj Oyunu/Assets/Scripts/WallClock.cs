using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{


    public class WallClock : MonoBehaviour
    {
        public Transform hourHand;    // Saat akrebi
        public Transform minuteHand;  // Saat yelkovanı
        public Transform secondHand;  // Saniye ibresi

        void Update()
        {
            // TimeManager'dan timePercent değerini al
            float timePercent = TimeManager.Instance.timePercent;

            // Günlük zamanı saat, dakika ve saniye olarak hesapla
            float hours = timePercent * 24f;
            float minutes = (hours - Mathf.Floor(hours)) * 60f;
            float seconds = (minutes - Mathf.Floor(minutes)) * 60f;

            // Akrebi, yelkovanı ve saniye ibresini döndür
            hourHand.localRotation = Quaternion.Euler(0f, 0f, -hours * 30f);    // Saat başına 30 derece (360 / 12)
            minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minutes * 6f); // Dakika başına 6 derece (360 / 60)
            secondHand.localRotation = Quaternion.Euler(0f, 0f, -seconds * 6f); // Saniye başına 6 derece (360 / 60)
        }
    }
}
