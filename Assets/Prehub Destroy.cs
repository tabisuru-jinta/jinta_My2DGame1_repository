using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrehubDestroy : MonoBehaviour
{
    const int destroy_height = -1;
    GameOperator go;
    void Start()
    {
        go = GameObject.Find("OperatorObject").GetComponent<GameOperator>();
    }
    void Update()
    {
        if(transform.position.y < destroy_height){
            //SceneManager.LoadScene("GameOverScene");
            go.deduction(1);
            Destroy(gameObject);
        }
    }
}
