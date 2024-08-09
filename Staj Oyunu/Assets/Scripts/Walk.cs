using DialogueEditor;
using Spine.Unity;
using Spine.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    public class Walk : MonoBehaviour
    {
        GameManager gameManager;
        private int _characterCount;
        private int _characterBackCount;
        private Vector2[] points = { new Vector3(-0.4f, 0f, 0), new Vector3(-0.6f, 2.3f, 0) };
        private int pointCount = 0;
        private float speed = 0.5f;
        int counter = 0;
        int counterTwo = 0;
        private NPCConversation _myConvarsation;
        private GameObject _myChar;
        SkeletonGraphic _skeletonGraphic;
        private void Start()
        {
            Load();
        }
        private void Awake()
        {
            _skeletonGraphic = transform.GetChild(0).transform.GetComponent<SkeletonGraphic>();
            gameManager = GameObject.Find("GameManager").transform.GetComponent<GameManager>();

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


                    if (direction.magnitude > 0.1f)
                    {

                        direction.Normalize();
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f,0);


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
                            transform.position = Vector3.MoveTowards(transform.position,new Vector3(-1.3f, 0, 0), speed * Time.deltaTime);
                            Vector2 direc = new Vector2(-1.3f, 0) - GetComponent<Rigidbody2D>().position;


                            if (direc.magnitude > 0.1f)
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
                            _skeletonGraphic.startingAnimation = "İdle";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                            counterTwo = 1;
                        }
                    }
                    else
                    {
                        if (counterTwo == 1)
                        {
                            _skeletonGraphic.startingAnimation = "Walk";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
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
                            _skeletonGraphic.startingAnimation = "Walk";
                            SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                            counter = 0;
                        }




                        transform.position = Vector3.MoveTowards(transform.position, points[pointCount], speed * Time.deltaTime);
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position, gameManager.characters[_characterCount - 1].transform.position + new Vector3(-0.6f, 0, 0), speed * Time.deltaTime);
                        if (gameManager.characters[_characterCount - 1].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                        {
                            Vector2 direction = new Vector2(gameManager.characters[_characterCount - 1].transform.position.x + -0.6f,this.gameObject.transform.position.y ) - GetComponent<Rigidbody2D>().position;


                            if (direction.magnitude > 0.1f)
                            {

                                direction.Normalize();
                                GetComponent<Rigidbody2D>().velocity = new Vector2(0.001f, 0);


                            }
                            else
                            {
                                if (counter == 0)
                                {
                                    _skeletonGraphic.startingAnimation = "İdle";
                                    SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);
                                    counter = 1;
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


                    if (direction.magnitude > 0.1f)
                    {

                        direction.Normalize();

                        if (counterTwo == 1)
                        {
                            _skeletonGraphic.freeze = false;
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
                            ConversationManager.Instance.StartConversation(_myConvarsation);
                            _skeletonGraphic.freeze = true;
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
                            _skeletonGraphic.freeze = false;
                            counter = 0;
                        }




                        transform.position = Vector3.MoveTowards(transform.position, points[1], speed * Time.deltaTime);
                    }
                    else
                    {
                        transform.position = Vector3.MoveTowards(transform.position, gameManager.charactersBack[_characterBackCount - 1].transform.position + new Vector3(0, -0.4f, 0), speed * Time.deltaTime);
                        if (gameManager.charactersBack[_characterBackCount - 1].GetComponent<Rigidbody2D>().velocity == Vector2.zero)
                        {
                            Vector2 direction = new Vector2(this.gameObject.transform.position.x, gameManager.charactersBack[_characterBackCount - 1].transform.position.y + -0.4f) - GetComponent<Rigidbody2D>().position;


                            if (direction.magnitude > 0.1f)
                            {

                                direction.Normalize();
                                


                            }
                            else
                            {
                                if (counter == 0)
                                {
                                    _skeletonGraphic.freeze = true;
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

                
               
                if (gameManager.characters.Contains(this.gameObject))
                {
                    _skeletonGraphic.startingAnimation = "İdle";
                    SpineEditorUtilities.ReloadSkeletonDataAssetAndComponent(_skeletonGraphic);


                    
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


        private void OnApplicationQuit()
        {
            PlayerPrefs.SetString(gameObject.name, JsonUtility.ToJson(this));
        }

        private void Load()
        {
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(gameObject.name),this);
        }


    }
}
