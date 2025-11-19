using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_GuidanceAi : MonoBehaviour
{
    public Image profile_GoodAi;
    public Image panel_GuidanceAi;
    public Image selected_Dialogue;
    public TMP_Text text_Option1;
    public TMP_Text text_Option2;
    public TMP_Text text_Option3;
    public TMP_Text text_GoodAi;


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
