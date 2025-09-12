using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AimOperator : MonoBehaviour
{
    // Start is called before the first frame update
    const float height = 6.5f;
    const float aimSize = 4 / 2;
    float width = 11f;
    const float sensitivity = 0.05f;
    float magnification;
    private GameObject mainCamera;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        //Debug.Log(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        //width = Screen.width/10;
        Vector3 mousePosition = Input.mousePosition - new Vector3(Screen.width,Screen.height,0)/2;//mousePositionÇâÊñ ÇÃíÜêSÇ…í≤êÆ
        //Debug.Log(transform.position.x);
        //aimÇÃà íu
        transform.position = mainCamera.transform.position + new Vector3(mousePosition.x*sensitivity,  height, -mainCamera.transform.position.z);
        if(transform.position.x < -width)transform.position = mainCamera.transform.position + new Vector3(-width, height, -mainCamera.transform.position.z);
        if(transform.position.x > width) transform.position = mainCamera.transform.position + new Vector3(width, height, -mainCamera.transform.position.z);
    }
}
