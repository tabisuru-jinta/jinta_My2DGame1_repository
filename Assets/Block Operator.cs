using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BlockOperator : MonoBehaviour
{
    // Start is called before the first frame update
    private const int Delete_height = -3;
    public bool heightCheck = false;
    GameObject oo;
    GameOperator go;
    SpriteRenderer renderer;


    void Start()
    {
        oo = GameObject.Find("OperatorObject");
        go = oo.GetComponent<GameOperator>();
        renderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < Delete_height)
        {
            Debug.Log("—Ž‚¿‚½");
            Destroy(this);
        }
        //if (heightCheck)
        //{
        //    if (go.highestBlock < transform.position.y)
        //    {
        //        go.highestBlock = transform.position.y;
        //        heightCheck = true;
        //        if (renderer != null) 
        //        {
        //            renderer.color = Color.red;
        //        }
        //    }
        //    else
        //    {
        //        if (renderer != null)
        //        {
        //            renderer.color = Color.white;
        //        }
        //    }
        //}
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        heightCheck = true;
    }
}
