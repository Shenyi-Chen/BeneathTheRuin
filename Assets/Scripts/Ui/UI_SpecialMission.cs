using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_SpecialMission : MonoBehaviour
{
    public Image panel_SpecialMission1;

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
