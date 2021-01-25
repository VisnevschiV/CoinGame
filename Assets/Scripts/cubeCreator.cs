using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCreator : MonoBehaviour
{
    public static bool end= false;
    public GameObject Cube;
    public GameObject Coin;
    public float maxleft= -4.7f;
    public float maxright=5.37f;
    public float timeBetwenSpawn;
    public static float _spawntime;
    // Start is called before the first frame update
    void Start()
    {
        _spawntime = coin.speed;
        InvokeRepeating("Spawner", 2.0f, _spawntime);
        InvokeRepeating("Coins", 6.0f, _spawntime);
    }
    void Spawner(){
        if(!end){
        Destroy(Instantiate(Cube, new Vector3(Random.Range(maxleft, maxright),0.42f,109f),Quaternion.identity).gameObject, 15);
        }
    }
     void Coins(){
        if(!end){
        Destroy(Instantiate(Coin, new Vector3(Random.Range(maxleft, maxright),0.42f,109f),Quaternion.identity).gameObject, 15);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
