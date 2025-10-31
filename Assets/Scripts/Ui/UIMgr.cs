using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;


    public UI_Loading ui_loading;
    public UI_Combat ui_Combat;
    public UI_Ai ui_Ai;
    public UI_GuidanceAi ui_GuidanceAi;
    public UI_GuidanceAi2 ui_GuidanceAi2;
    public UI_ToolPanel ui_ToolPanel;
    public UI_CombatResult ui_CombatResult;
    public UI_SpecialMission ui_SpecialMission;
    public UI_UndergroundCity ui_UndergroundCity;

    void Awake()
    {
        I = this;
        ui_loading.Init();
        ui_Combat.Init();
        ui_Ai.Init();
        ui_GuidanceAi.Init();
        ui_GuidanceAi2.Init();

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
