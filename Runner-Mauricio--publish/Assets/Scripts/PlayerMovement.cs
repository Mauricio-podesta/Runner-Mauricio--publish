using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody PlayerRB;
    [SerializeField] float Speedvalue = 5f;
    [SerializeField] float Jumpforce = 5f;
    [SerializeField] bool Check = true;
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        
        float movementrigthleft = Input.GetAxis("Horizontal") * Speedvalue;

        movementrigthleft *= Time.deltaTime;
        transform.Translate(movementrigthleft, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && Check)
        {
            PlayerRB.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
            Check = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("box"))
        {
            LoseMenssage.show();
            Time.timeScale = 0;
            LoseMenssage.Lose = true;
        }
        Check = true;
    }
  
}
