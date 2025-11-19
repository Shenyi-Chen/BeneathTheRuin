using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

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
        float horizontalValue = Input.GetAxis("Horizontal");
        var verticalValue = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", horizontalValue);
        animator.SetFloat("Vertical", verticalValue);

        Vector3 horizontal = new Vector3(horizontalValue, 0f, 0f);
        Vector3 vertical = new Vector3(0f,verticalValue, 0f);

        transform.position = transform.position + horizontal * Time.deltaTime * speed;
        transform.position = transform.position + vertical * Time.deltaTime * speed;
    }
}
