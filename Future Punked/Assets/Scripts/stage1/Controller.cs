using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float force = 0.1f;
    public float sideforce = 1000;

  
    protected Rigidbody rigidbody;
    protected Vector3 position = new Vector3(0.0f, 0.0f, 0.0f);

    void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        position = new Vector3(0.0f, 1.78f, 0.0f);
        rigidbody.MovePosition(position);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            position.Set(sideforce * Time.deltaTime + force, 0.0f, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.Set(--sideforce * Time.deltaTime + force, 0.0f, 0.0f);
        }
        rigidbody.MovePosition(position);
    }
}
