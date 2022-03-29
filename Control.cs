using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public static int kol = 0;
    public static int non = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1;
        rb.drag = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Destroy(gameObject);
        kol += 1;
        if (kol > 5 && non < 6)
        {
            print("you win");
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "nooo")
        {
            non = non + 1;
            if (non > 5 && kol < 6)
            {
                print("you lose");
            }
        }
        if (col.gameObject.tag == "good")
        {
            rb.AddForce(50f, 0, 0);

        }
        rb.AddForce(0, 250f, 0);
    }
}