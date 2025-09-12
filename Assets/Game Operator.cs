using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOperator : MonoBehaviour
{
    const int ScreenSize = 10;
    float cameraSpeed = 2;
    public TextMeshProUGUI ScoreText;
    public float highestBlock = 0;
    public float outestBlock = 0;
    private int high = 0;
    float cameraZoom = 0.1f;
    public bool IsGameOver = false;
    private int PointDeduction = 0;
    BlockCreator blockCreator;
    void Start()
    {
        ScoreText.text = "hello Score";
        blockCreator = this.GetComponent<BlockCreator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreText.text = $"<mark=#ffffff>score: {(int)highestBlock}</mark>\r\n";
        ScoreText.text = $"score: {(high - PointDeduction > 0 ? high - PointDeduction:0)}";

        if (high < highestBlock) high = (int)highestBlock;
        if (Camera.main.transform.position.y >= (float)(high-0.5)) blockCreator.IsOk = true;
        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(0, high, -10), Time.deltaTime * cameraSpeed);
        if(highestBlock < Camera.main.transform.position.y - ScreenSize && !IsGameOver)//Å‚à‚‚¢ƒuƒƒbƒN‚ª‰æ–Ê‚©‚çŒ©‚¦‚È‚¢‚Ù‚Ç•ö‚ê‚½‚çGO
        {
            IsGameOver = true;
            Debug.Log("GameOver!!");
            GameOver();
        }
        highestBlock = 0;
    }
    private void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
    public void deduction(int point)
    {
        PointDeduction += point;
    }

}
