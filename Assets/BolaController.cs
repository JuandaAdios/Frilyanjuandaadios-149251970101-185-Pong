using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{

    public Vector2 speed;

    private Rigidbody2D rig;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        //GetComponent<Transform>();
        //Vector3 pos = transform.position;
        //Transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
    }
}