using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2.0f;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
      
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, Time.deltaTime * speed, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, -Time.deltaTime * speed, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            transform.Translate(-Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            transform.Translate(Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Jelly 9")
            Debug.Log("Hello");
    }
}
