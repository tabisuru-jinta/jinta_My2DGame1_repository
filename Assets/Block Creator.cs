using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;
using UnityEngine.UIElements;

public class BlockCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clone_prehub, next_prehub, prehub_L,prehub_T,prehub_O,prehub_X;
    private GameObject aim;
    private GameObject blockBox;
    float coolTime = 0.8f;
    bool IsCoolTime;
    public int blockNum = 0;
    const int prehubNum = 4;
    GameObject clone,next_clone;
    private GameObject mainCamera;
    void Start()
    {
        //for(float i = 0;i < 10; i+=2)
        //{
        //    Instantiate(prehub, new Vector2(i-6, 0), Quaternion.identity);
        //}
        IsCoolTime = false;
        aim = GameObject.Find("Aim");
        mainCamera = GameObject.Find("Main Camera");
        blockBox = GameObject.Find("BlockBox");
        block_choose(ref next_prehub);
        block_choose(ref clone_prehub);
        next_clone = Instantiate(next_prehub, new Vector2(0,0), Quaternion.identity, blockBox.transform);
        clone = Instantiate(clone_prehub, aim.transform.position, Quaternion.identity, blockBox.transform);

    }

    // Update is called once per frame
    void Update()
    {
        if(!IsCoolTime)clone.transform.position = aim.transform.position ;
        next_clone.transform.position = new Vector2(Camera.main.transform.position.x-15, Camera.main.transform.position.y); //次のブロックの掲示

        if ((Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space)) && !IsCoolTime)
        {
            if (clone != null)
            {
                
                blockNum++;
                string newName = "block" + blockNum.ToString();
                clone.name = newName;
                //clone.transform.position -= new Vector3(0, 2, 0); //次のクローンと衝突しないための生成位置調整
                clone.AddComponent<Rigidbody2D>();
                PrehubOperator prehubOperator = clone.GetComponent<PrehubOperator>();
                prehubOperator.AddCollider(); //プレハブ下の各ブロックに当たり判定を追加
                //clone.AddComponent<BoxCollider2D>();
            }
            else
            {
                Debug.Log("clone　が　null　です");
            }
            IsCoolTime = true;
            
            //next_prehub.transform.position = next_prehub_position;
            Invoke("CoolTime_Reset", coolTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            clone.transform.Rotate( new Vector3(0,0,90));
            //Debug.Log("Rotate");
        }
    }
    void CoolTime_Reset()
    {
        clone = next_clone;
        block_choose(ref next_prehub);
        next_clone = Instantiate(next_prehub, new Vector2(0, 0), Quaternion.identity, blockBox.transform);
        IsCoolTime = false;
    }
    void block_choose(ref GameObject go)
    {
        System.Random random = new System.Random();
        switch (random.Next(1, prehubNum + 1))
        {
            case 1:
                go = prehub_L;
                break;
            case 2:
                go = prehub_T;
                break;
            case 3:
                go = prehub_O;
                break;
            case 4:
                go = prehub_X;
                break;
            default:
                go = prehub_L;
                break;
        }
    }
}
