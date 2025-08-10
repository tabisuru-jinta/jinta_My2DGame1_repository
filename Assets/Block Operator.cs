using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BlockOperator : MonoBehaviour
{
    // Start is called before the first frame update
    private const int Delete_height = -3;
    bool heightCheck = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < Delete_height)
        {
            Debug.Log("—Ž‚¿‚½");
            Destroy(this);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!heightCheck)
        {
            GameObject oo = GameObject.Find("OperatorObject");
            var go = oo.GetComponent<GameOperator>();

            if(go.highestBlock < transform.position.y)
            {
                go.highestBlock = transform.position.y;
                heightCheck = true;
            }
            if(go.outestBlock < Mathf.Abs(transform.position.x))
            {
                go.outestBlock = Mathf.Abs(transform.position.x);
            }
        }
    }
}
