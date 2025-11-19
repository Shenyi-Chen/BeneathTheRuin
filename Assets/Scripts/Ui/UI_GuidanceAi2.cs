using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_GuidanceAi2 : MonoBehaviour
{
    public Image profile_BadAi;
    public Image panel_GuidanceAi2;
    public TMP_Text text_BadAi;

    public void Init()
    {

       Hide();

    }
    
    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }

    private void Awake() { }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
