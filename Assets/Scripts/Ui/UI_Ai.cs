using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class UI_Ai : MonoBehaviour
{
    public Button btn_AiProfile;
    public Button btn_AiProfileBlue;
    public Button btn_AiProfileRed;
    public UI_GuidanceAi ui_GuidanceAi;
    public UI_GuidanceAi2 ui_GuidanceAi2;
    public UI_ToolPanel ui_ToolPanel;

  
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
        // 给按钮添加点击事件
        btn_AiProfile.onClick.AddListener(AiProfile);
        btn_AiProfileBlue.onClick.AddListener(AiProfileBlue);
        btn_AiProfileRed.onClick.AddListener(AiProfileRed);
        // 确保一开始面板是隐藏的
        ui_ToolPanel.gameObject.SetActive(false);
        ui_GuidanceAi.gameObject.SetActive(false);
        ui_GuidanceAi2.gameObject.SetActive(false);
    }

    void AiProfile()
    {
        // 点击按钮后显示面板
        ui_ToolPanel.gameObject.SetActive(true);
    }

    void AiProfileBlue()
    {
        ui_GuidanceAi.gameObject.SetActive(true);
    }

    void AiProfileRed()
    {
        ui_GuidanceAi2.gameObject.SetActive(true);
    }
       
   // Update is called once per frame
    void Update()
    {
        
    }
}
