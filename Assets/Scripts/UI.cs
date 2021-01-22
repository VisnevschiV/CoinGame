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
        obst.ObstmoveSpeed = 8f;
        lost.SetActive(false);
    }
}
