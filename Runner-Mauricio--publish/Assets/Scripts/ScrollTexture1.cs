using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture1 : MonoBehaviour
{
    [SerializeField] Material floor;
    [SerializeField] float scroll;
    [SerializeField] float speed;
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        floor = renderer.material;
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        scroll += speed;
        floor.SetFloat("Movimientoy", scroll);
    }
}
