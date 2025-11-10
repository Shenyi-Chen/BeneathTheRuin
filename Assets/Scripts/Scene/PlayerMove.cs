using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Vector3 vertical = new Vector3(0f, Input.GetAxis("Vertical"), 0f);

        transform.position = transform.position + horizontal * Time.deltaTime * speed;
        transform.position = transform.position + vertical * Time.deltaTime * speed;
    }
}
