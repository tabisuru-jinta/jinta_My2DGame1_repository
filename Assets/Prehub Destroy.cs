using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrehubDestroy : MonoBehaviour
{
    const int destroy_height = -1;
    void Start()
    {
        
    }
    void Update()
    {
        if(transform.position.y < destroy_height)Destroy(gameObject);
    }
}
