using DialogueEditor;
using Spine.Unity;

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        GameManager gameManager;
        private int _characterCount;
        private int _characterPrefabCount;
        private int _characterBackCount;
        private Vector2[] points = { new Vector3(-0.4f, 0f, 0), new Vector3(-0.6f, 2.3f, 0) };
        private int pointCount = 0;
        private float speed = 0.5f;
        int counter = 0;
        int counterTwo = 0;
        private NPCConversation _myConvarsation;
        private GameObject _myChar;
        public List<SkeletonGraphic> _skeletonGraphic;
        TMP_Text myText;
        private void Awake()
        {
           
            // for çalışmıyor
            if (transform.childCount == 2)
            {
                _skeletonGraphic.Add(transform.GetChild(0).transform.GetComponent<SkeletonGraphic>());
            }
            if (transform.childCount == 3)
            {
                _skeletonGraphic.Add(transform.GetChild(0).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(1).transform.GetComponent<SkeletonGraphic>());
            }
            if (transform.childCount == 4)
            {
                _skeletonGraphic.Add(transform.GetChild(0).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(1).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(2).transform.GetComponent<SkeletonGraphic>());
            }
            if (transform.childCount == 5)
            {
                _skeletonGraphic.Add(transform.GetChild(0).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(1).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(2).transform.GetComponent<SkeletonGraphic>());
                _skeletonGraphic.Add(transform.GetChild(3).transform.GetComponent<SkeletonGraphic>());
            }


            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
            myText = gameManager.myText;
            
        }
        private void Update()
        {
            CharacterQuery();
        }

        private void CharacterQuery()
        {
            if (gameManager.characters.Contains(this.gameObject))
            {


                for (int i = 0; i <= gameManager.characters.Count - 1; i++)
                {

                    if (this.gameObject == gameManager.characters[i])
                    {

                        _characterCount = i;

                        break;
                    }


                }




                if (gameManager.characters[0] == this.gameObject)
                {
                    Vector2 direction = points[pointCount] - GetComponent<Rigidbody2D>().position;


                    if (direction.magnitude > 0.01f)
                    {

                        direction.Normalize();
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f, 0);


                    }
                    else
                    {

                        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                    }

                    if (gameManager.charactersBack.Count == 0)
                    {

                        transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                    }
                    else
                    {
                        if (gameManager.charactersBack.Count == 6)
                        {
                            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-1.3f, 0, 0), speed * Time.deltaTime);
                            Vector2 direc = new Vector2(-1.3f, 0) - GetComponent<Rigidbody2D>().position;


                            if (direc.magnitude > 0.01f)
                            {

                                direc.Normalize();
                                GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f, 0);


                            }
                            else
                            {

                                GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                            }
                        }
                        else
                        {
                            transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                        }
                    }


                    if (gameManager.characters[0].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                    {

                        if (counterTwo == 0)
                        {
                            foreach (var item in _skeletonGraphic)
                            {
                                item.AnimationState.SetAnimation(1, "İdle", true);
                            }


                            counterTwo = 1;
                        }
                    }
                    else
                    {
                        if (counterTwo == 1)
                        {
                            foreach (var item in _skeletonGraphic)
                            {
                                item.AnimationState.SetAnimation(1, "Walk", true);
                            }


                            counterTwo = 0;
                        }
                    }
                }
                else
                {
                    if (gameManager.characters[_characterCount - 1].activeSelf == false)
                    {



                        if (counter == 1)
                        {
                            foreach (var item in _skeletonGraphic)
                            {
                                item.AnimationState.SetAnimation(1, "Walk", true);
                            }


                            counter = 0;
                        }




                        transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position, gameManager.characters[_characterCount - 1].transform.position + new Vector3(-0.6f, 0, 0), speed * Time.deltaTime);
                        if (gameManager.characters[_characterCount - 1].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                        {
                            Vector2 direction = new Vector2(gameManager.characters[_characterCount - 1].transform.position.x + -0.6f, this.gameObject.transform.position.y) - GetComponent<Rigidbody2D>().position;


                            if (direction.magnitude > 0.1f)
                            {

                                direction.Normalize();
                                GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f, 0);

                                if (counter == 1)
                                {
                                    foreach (var item in _skeletonGraphic)
                                    {
                                        item.AnimationState.SetAnimation(1, "Walk", true);
                                    }

                                    counter = 0;
                                }



                            }
                            else
                            {
                                if (gameManager.characters[0].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                                {
                                    if (counter == 0)
                                    {
                                        foreach (var item in _skeletonGraphic)
                                        {
                                            item.AnimationState.SetAnimation(1, "İdle", true);
                                        }

                                        counter = 1;
                                    }
                                }
                                GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                            }

                        }
                    }
                }
            }

            /*-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            if (gameManager.charactersBack.Contains(this.gameObject))
            {


                for (int i = 0; i <= gameManager.charactersBack.Count - 1; i++)
                {

                    if (this.gameObject == gameManager.charactersBack[i])
                    {

                        _characterBackCount = i;

                        break;
                    }


                }




                if (gameManager.charactersBack[0] == this.gameObject)
                {
                    Vector2 direction = points[1] - GetComponent<Rigidbody2D>().position;


                    if (direction.magnitude > 0.01f)
                    {

                        direction.Normalize();

                        if (counterTwo == 1)
                        {
                            foreach (var item in _skeletonGraphic)
                            {
                                item.freeze = false;
                            }
                            counterTwo = 0;
                        }

                    }
                    else
                    {

                        if (counterTwo == 0)
                        {
                            if (TryGetComponent<NPCConversation>(out NPCConversation nPC))
                            {
                                _myConvarsation = GetComponent<NPCConversation>();
                            }
                            if (gameObject.name == "Misafirlerb23(Clone)" || gameObject.name == "Misafirlerb5(Clone)" || gameObject.name == "Misafirlerb3(Clone)" ||
                                gameObject.name == "Misafirlerb10(Clone)" || gameObject.name == "Misafirlerb15(Clone)" || gameObject.name == "Misafirlerb20(Clone)")
                            {
                                if (gameManager.story.dialog5 == true)
                                {

                                }
                                else
                                {
                                    for (int i = 0; i <= gameManager.charactersBackPrefab.Count - 1; i++)
                                    {

                                        if (this.gameObject.name.Replace("(Clone)", "").Trim() == gameManager.charactersBackPrefab[i].name)
                                        {

                                            _characterPrefabCount = i;
                                            gameManager.sıradakiCount = i;
                                            break;
                                        }


                                    }
                                    ConversationManager.Instance.StartConversation(_myConvarsation);
                                    ConversationManager.Instance.SetInt("stori", gameManager.story.dialogSayac[_characterPrefabCount]);
                                    gameManager.sayac = ConversationManager.Instance.GetInt("stori");

                                }

                            }
                            else
                            {
                                for (int i = 0; i <= gameManager.charactersBackPrefab.Count - 1; i++)
                                {

                                    if (this.gameObject.name.Replace("(Clone)", "").Trim() == gameManager.charactersBackPrefab[i].name)
                                    {

                                        _characterPrefabCount = i;
                                        gameManager.sıradakiCount = i;
                                        break;
                                    }


                                }
                                ConversationManager.Instance.StartConversation(_myConvarsation);

                            }

                            foreach (var item in _skeletonGraphic)
                            {
                                item.freeze = true;
                            }
                            counterTwo = 1;
                        }

                    }
                    transform.position = Vector3.MoveTowards(transform.position, points[1], speed * Time.deltaTime);

                }
                else
                {
                    if (gameManager.charactersBack[_characterBackCount - 1].activeSelf == false)
                    {



                        if (counter == 1)
                        {
                            foreach (var item in _skeletonGraphic)
                            {
                                item.freeze = false;
                            }

                            counter = 0;
                        }




                        transform.position = Vector3.MoveTowards(transform.position, points[1], speed * Time.deltaTime);
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position, gameManager.charactersBack[_characterBackCount - 1].transform.position + new Vector3(0, -0.6f, 0), speed * Time.deltaTime);
                        if (gameManager.charactersBack[_characterBackCount - 1].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                        {
                            Vector2 direction = new Vector2(this.gameObject.transform.position.x, gameManager.charactersBack[_characterBackCount - 1].transform.position.y + -0.6f) - GetComponent<Rigidbody2D>().position;


                            if (direction.magnitude > 0.01f)
                            {

                                direction.Normalize();



                            }
                            else
                            {
                                if (counter == 0)
                                {
                                    foreach (var item in _skeletonGraphic)
                                    {
                                        item.freeze = true;
                                    }

                                    counter = 1;
                                }


                            }

                        }
                    }
                }

            }

        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "adimİlk")
            {


                Debug.Log("hbjfs");
                if (gameManager.characters.Contains(this.gameObject))
                {

                    foreach (var item in _skeletonGraphic)
                    {
                        item.AnimationState.SetAnimation(1, "İdle", true);
                    }



                    _myChar = Instantiate(gameManager.charactersBackPrefab[int.Parse(gameObject.tag) - 1]);


                    _myChar.gameObject.transform.parent = GameObject.Find("Canvas").gameObject.transform;
                    _myChar.transform.position = this.gameObject.transform.position;
                    _myChar.transform.rotation = Quaternion.identity;
                    gameManager.charactersBack.Add(_myChar);
                    gameManager.characters[_characterCount].SetActive(false);
                    gameManager.characters.Remove(this.gameObject);
                }
                if (gameManager.charactersBack.Contains(this.gameObject))
                {
                    pointCount = +1;

                }



            }

        }
        public void yokOl()
        {
            int sayac;
            sayac = ConversationManager.Instance.GetInt("stori");
            gameManager.story.dialogSayac[_characterPrefabCount] = sayac + 1;
            gameManager.charactersBack.Remove(gameObject);
            Destroy(gameObject);
        }
        public void anahtarAç()
        {
            gameManager.odaVeriTabanıı.gün = ConversationManager.Instance.GetInt("gün");
            gameManager.keys.SetActive(true);
        }
        public void anahtarKapa()
        {
            gameManager.keys.SetActive(false);
        }

        public void ParaEkleT()
        {
            gameManager.story.para = int.Parse(myText.text) + (7 * 1000);
            myText.text = gameManager.story.para.ToString();
        }

        public void ParaEkleC()
        {
            gameManager.story.para = int.Parse(myText.text) + (7 * 1500);
            myText.text = gameManager.story.para.ToString();
        }
        public void ParaEkleTek()
        {
            gameManager.story.para = int.Parse(myText.text) + 1000;
            myText.text = gameManager.story.para.ToString();
        }

        public void ParaEkleCok()
        {
            gameManager.story.para = int.Parse(myText.text) + 1500;
            myText.text = gameManager.story.para.ToString();
        }
        public void MektupEkle()
        {
            Inventory halı = new Inventory(gameManager, gameManager.inventoryItems[1], "mektup");
            gameManager.InventorySaveGame();
            gameManager.story.dialog5 = true;
        }
    }
}
