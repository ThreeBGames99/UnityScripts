using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poruszanie : MonoBehaviour {
    public float rotspeed = 3;
    public float speed = 3;
    private void Start()
    {
        Quaternion a = Quaternion.Euler(0,0,0);
        Quaternion b = Quaternion.Euler(0, 0, 360);
    }
    void Update() {
       
    
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * speed / 2 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * speed / 2 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * Time.deltaTime * rotspeed);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.back * Time.deltaTime * rotspeed);

    }
}
