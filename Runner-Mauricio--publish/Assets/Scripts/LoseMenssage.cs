using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoseMenssage : MonoBehaviour
{
    public GameObject LoseText;
    public static GameObject LoseStatic;
    public static bool Lose;
    public GameObject LoseImage;
    public static GameObject LoseImageStatic;
    public Text ScoreTXT;
    public float score; 
    void Start()
    {
        Lose = false;
        LoseMenssage.LoseStatic = LoseText;
        LoseMenssage.LoseStatic.gameObject.SetActive(false);
        LoseMenssage.LoseImageStatic = LoseImage;
        LoseMenssage.LoseImageStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = score + 1 * Time.deltaTime;
        ScoreTXT.text = score.ToString("F2");
        if (Lose)
            if (Input.GetKeyUp(KeyCode.R)) {

                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
    }
    public static void show() {
        LoseMenssage.LoseStatic.gameObject.SetActive(true);
        LoseMenssage.LoseImageStatic.gameObject.SetActive(true);
    }
 }
