using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementy : MonoBehaviour
{
    [SerializeField ] private float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
