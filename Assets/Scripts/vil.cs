using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vil : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time <= 3)
        {
            transform.Translate(Time.deltaTime * 2, 0, 0);
            spriteRenderer.flipX = true;
            //animator.SetBool("isMove", true);
        }
        else if (time >= 3 && time <= 6)
        {
            transform.Translate(-Time.deltaTime * 2, 0, 0);
            spriteRenderer.flipX = false;
            //animator.SetBool("isMove", true);

        }
        else
        {
            time = 0;
        }
    }
}
