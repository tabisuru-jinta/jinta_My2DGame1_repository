using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraOperator : MonoBehaviour
{
    // Start is called before the first frame update
    GameOperator go;
   
    void Start()
    {
        go = GetComponent<GameOperator>();
    }

    // Update is called once per frame
    void Update()
    {


        //if( go.highestBlock > 0)
        //{
        //    Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(0, go.highestBlock, -10), Time.deltaTime);
        //}
        
        
        //if(Camera.main.orthographicSize < (float)(5 + go.outestBlock / 3))
        //{
        //    Camera.main.orthographicSize += cameraZoom * Time.deltaTime;
        //}   
        
        
    }
}
