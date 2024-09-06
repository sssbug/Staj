using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DialogueEditor;
using Spine.Unity;
using UnityEngine.UI;

namespace DS
{
    public class Odaler : MonoBehaviour, IPointerClickHandler
    {
        GameManager2 gameManager;
        private NPCConversation _myConvarsation;
        private SkeletonGraphic _skeletonGraphic;

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

                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);

                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }


            }
            if (clickedObject != null && clickedObject.tag == "2")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "3")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "4")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "5")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "6")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "7")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "8")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "9")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "10")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "11")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "12")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "13")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "14")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "15")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "17")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "18")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "19")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }

            if (clickedObject != null && clickedObject.tag == "20")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }

            if (clickedObject != null && clickedObject.tag == "22")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "23")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "24")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "25")
            {

                ConversationManager.Instance.StartConversation(_myConvarsation);
                if (TimeManager.Instance.story.gunSayacı == 0)
                {
                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                }
                else
                {
                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                }

                ConversationManager.Instance.SetInt("misafir", 25);


            }
            if (clickedObject != null && clickedObject.tag == "26")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "27")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "28")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "29")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "31")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "32")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "33")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "34")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "35")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "36")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
            }
            if (clickedObject != null && clickedObject.tag == "37")
            {
                if (gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)] != null)
                {
                    for (int i = 1; i < gameManager.Characters.Count; i++)
                    {
                        if (gameManager.Characters[i] != null)
                        {
                            if (gameManager.Characters[i].name == gameManager.odaVeriTabanıı.isimdata[int.Parse(clickedObject.tag)])
                            {
                                ConversationManager.Instance.StartConversation(_myConvarsation);
                                if (TimeManager.Instance.story.gunSayacı == 0)
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı);
                                }
                                else
                                {
                                    ConversationManager.Instance.SetInt("gun", TimeManager.Instance.story.gunSayacı + 1);
                                }
                                clickedObject.transform.GetChild(1).GetComponent<Image>().sprite = gameManager.sprites[i];
                                ConversationManager.Instance.SetInt("globalGorev", TimeManager.Instance.story.globalGorev);
                                ConversationManager.Instance.SetInt("sorgulama", TimeManager.Instance.story.sorgulama);
                                ConversationManager.Instance.SetInt("misafir", i);
                                _skeletonGraphic = clickedObject.transform.GetChild(2).GetComponent<SkeletonGraphic>();
                                _skeletonGraphic.AnimationState.SetAnimation(1, "Open", false);
                                gameManager.closePlease = clickedObject;
                                break;
                            }
                        }



                    }
                }
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
