using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindwormGraveyard : MonoBehaviour
{
    public GameObject mc;

    public void Init()
    {
        Hide();
    }

    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }

    private void Awake()
    {
      
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
