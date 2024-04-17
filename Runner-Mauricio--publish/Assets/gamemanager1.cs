using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager1 : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject[] box;

    [SerializeField] Transform Spawnboxposition;
    [SerializeField] Transform Spawnbotposition2;
    [SerializeField] Transform Spawnbotposition3;
    public Text ScoreTXT;
    public static float score;
    void Start()
    {
        Startgame();
        InvokeRepeating("spawn", 2f, 3f);
        InvokeRepeating("Spawn2", 1f, 5f);
        InvokeRepeating("Spawn3", 0f, 7f);

    }

    void Startgame()
    {
        //Player.transform.position = new Vector3(0f, 0f, 0f);
        //StartCoroutine(Comenzarcronometro(30));
        score = 0;

    }
    void spawn()
    {
        //GameObject NewBOX = Instantiate(box, Spawnboxposition.position, Quaternion.identity);
        int Randomindex = Random.Range(0, box.Length - 1);
        GameObject obstaculoaleatorio = box[Randomindex];
        Instantiate(obstaculoaleatorio, Spawnboxposition.position, obstaculoaleatorio.transform.rotation);
    }
    void Spawn2()
    {
        int Randomindex = Random.Range(0, box.Length);
        GameObject obstaculoaleatorio = box[Randomindex];
        GameObject NewBOT = Instantiate(obstaculoaleatorio, Spawnbotposition2.position, Quaternion.identity);
    }
    void Spawn3()
    {
        int Randomindex = Random.Range(0, box.Length - 1);
        GameObject obstaculoaleatorio = box[Randomindex];
        GameObject NewBOT = Instantiate(obstaculoaleatorio, Spawnbotposition3.position, Quaternion.identity);
    }
    void Update()
    {
        score = score + 1 * Time.deltaTime;
        ScoreTXT.text = "Score:" + score.ToString("F2");
    }
}
