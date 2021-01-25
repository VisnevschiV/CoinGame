using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject lost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgain(){
        cubeCreator.end= false;
        lost.SetActive(false);
        obst.ObstmoveSpeed=20f;
        coin.speed = 2f;
    }
}
