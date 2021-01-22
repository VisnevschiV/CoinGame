using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float moveSpeed;
    public GameObject lost;
    public static int Coins=1;
    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject Coin5;
    public GameObject Coin6;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GO");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime,0f,0f);
       
        
    }
    void OnCollisionEnter(Collision Info){
            Debug.Log("AGHH");
            Debug.Log(Info.collider.name);
            if(Info.collider.name == "box(Clone)" ){
                if(Coins==1){
                Debug.Log("u Lost");
                obst.ObstmoveSpeed = 0.2f;
                cubeCreator.end= true;
                Invoke("GameOver", 2.0f);
                
                lost.SetActive(true);}else{
                    Coins--;
                    Destroy(Info.gameObject);
                    switch (Coins){
                    case 1:
                        Coin1.SetActive(false);
                    break;
                    case 2:
                        Coin2.SetActive(false);
                    break;
                    case 3:
                        Coin3.SetActive(false);
                    break;
                    case 4:
                        Coin4.SetActive(false);
                    break;
                    case 5:
                        Coin5.SetActive(false);
                    break;
                    case 6:
                        Coin6.SetActive(false);
                    break;
                };
                }
            } else if (Info.collider.name == "Coin (1)(Clone)"){
                Debug.Log("coin");
                Destroy(Info.gameObject);
                Coins++;
                switch (Coins){
                    case 2:
                        Coin1.SetActive(true);
                    break;
                    case 3:
                        Coin2.SetActive(true);
                    break;
                    case 4:
                        Coin3.SetActive(true);
                    break;
                    case 5:
                        Coin4.SetActive(true);
                    break;
                    case 6:
                        Coin5.SetActive(true);
                    break;
                    case 7:
                        Coin6.SetActive(true);
                    break;
                }
            }
        }
    void GameOver(){
            var clones = GameObject.FindGameObjectsWithTag ("Box");
                foreach (var clone in clones){
                Destroy(clone);
                }
    }
    
}
