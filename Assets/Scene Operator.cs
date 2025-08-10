using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOperator : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResetButton()
    {
        Debug.Log("ResetButton!");
        SceneManager.LoadScene("GameScene");
    }
}
