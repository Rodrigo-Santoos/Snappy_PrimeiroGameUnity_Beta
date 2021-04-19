using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private Rigidbody2D objRB;
    void Start()
    {
        objRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        objRB.velocity = new Vector2(-5f,0f);
    }
}
