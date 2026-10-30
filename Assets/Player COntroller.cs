using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerCOntroller : MonoBehaviour
{   
    public Vector3 WDir = new Vector3(1, 0, 0);
    public Vector3 ADir = new Vector3(1, 0, 0);
    public Vector3 SDir = new Vector3(1, 0, 0);
    public Vector3 DDir = new Vector3(1, 0, 0);
    public int moveSpeed = 5;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(WDir * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(ADir * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(SDir * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(DDir * moveSpeed, ForceMode.Force);
        }
    }

    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Lava")){
            Time.timeScale = 0f;
        }
    }
}
