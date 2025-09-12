using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrehubOperator : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Check = false;
    GameObject[] childObjects;
    BlockOperator[] childComponents;
    GameOperator go;

    void Start()
    {
        int ChildCount = this.transform.childCount;
        childObjects = new GameObject[ChildCount];
        childComponents = new BlockOperator[ChildCount];
        for(int i = 0;i < ChildCount; i++)
        {
            Transform childTransform = this.transform.GetChild(i);
            childObjects[i] = childTransform.gameObject;
            childComponents[i] = childObjects[i].GetComponent<BlockOperator>();
        }

        go = GameObject.Find("OperatorObject").GetComponent<GameOperator>();
    }

    void Update()
    {
        float highest = 0;
        if (Check)
        {
            foreach (GameObject child in childObjects)
            {
                if (highest < child.transform.position.y) highest = child.transform.position.y;
                //SpriteRenderer spriteRenderer = child.GetComponent<SpriteRenderer>();
                //spriteRenderer.color = Color.red;
            }
            if(go.highestBlock < highest)go.highestBlock = highest;
        }
        else
        {
            foreach (BlockOperator child in childComponents)
            {
                if (child.heightCheck)
                {
                    Check = true;
                    break;
                }
            }
        }

    }
    public void AddCollider()
    {
        foreach (BlockOperator child in childComponents)
        {
            child.AddComponent<BoxCollider2D>();
        }
    }
}
