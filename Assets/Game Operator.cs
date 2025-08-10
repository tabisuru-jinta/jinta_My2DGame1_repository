using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOperator : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public float highestBlock = 0;
    public float outestBlock = 0;
    float cameraZoom = 0.1f;
    void Start()
    {
        ScoreText.text = "hello Score";
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"score: {highestBlock}";

        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(0, highestBlock, -10), Time.deltaTime);
        if (Camera.main.orthographicSize < (float)(5 + outestBlock / 3))
        {
            Camera.main.orthographicSize += cameraZoom * Time.deltaTime;
        }
    }
}
