using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclemovement : MonoBehaviour
{
    [SerializeField] float Speedvalue = 3f;
    [SerializeField] private float LifeTime = 0f;
    [SerializeField] private float MaxLifeTime = 10f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(0, 0,  -Speedvalue * Time.deltaTime);
        LifeTime += Time.deltaTime;
        if (LifeTime >= MaxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}

