using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOperator : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetButton();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            HelpButton();
        }
    }



    public void ResetButton()
    {
        Debug.Log("ResetButton!");
        SceneManager.LoadScene("GameScene");
    }
    public void HelpButton()
    {
        SceneManager.LoadScene("HelpScene");
    }


}
