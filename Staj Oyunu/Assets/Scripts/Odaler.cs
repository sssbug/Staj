using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DialogueEditor;
namespace DS
{
    public class Odaler : MonoBehaviour, IPointerClickHandler
    {
        GameManager2 gameManager;
        private NPCConversation _myConvarsation;

        void Start()
        {
            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
            {
                _myConvarsation = GetComponent<NPCConversation>();
            }
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager2>();
        }


        public void OnPointerClick(PointerEventData eventData)
        {

            GameObject clickedObject = eventData.pointerPress;

            if (clickedObject != null && clickedObject.tag == "1")
            {
                //Debug.Log("sefsf");
                //for (int i = 0; i < gameManager.Characters.Count; i++)
                //{
                //    if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                //    {
                //        ConversationManager.Instance.StartConversation(_myConvarsation);
                //        ConversationManager.Instance.SetInt("misafir", i);

                //    }

                //}
                
            }
            if (clickedObject != null && clickedObject.tag == "2")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "3")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "4")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "5")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "6")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "7")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "8")
            {
                Debug.Log(gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.tag)]);
                Debug.Log(gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)]);
            }
            if (clickedObject != null && clickedObject.tag == "9")
            {

            }
            if (clickedObject != null && clickedObject.tag == "10")
            {

            }
            if (clickedObject != null && clickedObject.tag == "11")
            {

            }
            if (clickedObject != null && clickedObject.tag == "12")
            {

            }
            if (clickedObject != null && clickedObject.tag == "13")
            {

            }
            if (clickedObject != null && clickedObject.tag == "14")
            {

            }
            if (clickedObject != null && clickedObject.tag == "15")
            {

            }
            if (clickedObject != null && clickedObject.tag == "16")
            {

            }
            if (clickedObject != null && clickedObject.tag == "17")
            {

            }
            if (clickedObject != null && clickedObject.tag == "18")
            {

            }
            if (clickedObject != null && clickedObject.tag == "19")
            {

            }
            if (clickedObject != null && clickedObject.tag == "20")
            {

            }
            if (clickedObject != null && clickedObject.tag == "21")
            {

            }
            if (clickedObject != null && clickedObject.tag == "22")
            {

            }
            if (clickedObject != null && clickedObject.tag == "23")
            {

            }
            if (clickedObject != null && clickedObject.tag == "24")
            {

            }
            if (clickedObject != null && clickedObject.tag == "25")
            {

            }
            if (clickedObject != null && clickedObject.tag == "26")
            {

            }
            if (clickedObject != null && clickedObject.tag == "27")
            {

            }
            if (clickedObject != null && clickedObject.tag == "28")
            {

            }
            if (clickedObject != null && clickedObject.tag == "29")
            {

            }
            if (clickedObject != null && clickedObject.tag == "31")
            {

            }
            if (clickedObject != null && clickedObject.tag == "32")
            {

            }
            if (clickedObject != null && clickedObject.tag == "33")
            {

            }
            if (clickedObject != null && clickedObject.tag == "34")
            {

            }
            if (clickedObject != null && clickedObject.tag == "35")
            {

            }
            if (clickedObject != null && clickedObject.tag == "36")
            {

            }
            if (clickedObject != null && clickedObject.tag == "37")
            {

            }
            if (clickedObject != null && clickedObject.tag == "temizlik")
            {
                gameManager.odaVeriTabanıı.temizlikOdalar[int.Parse(clickedObject.transform.parent.gameObject.tag)] = false;
                Debug.Log("tıkla");

                Destroy(clickedObject);
            }


        }
    }
}
