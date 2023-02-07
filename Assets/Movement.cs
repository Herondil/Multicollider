using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*speed);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision between "+collision.otherCollider.name+" et "+collision.collider.name);
    }
}
