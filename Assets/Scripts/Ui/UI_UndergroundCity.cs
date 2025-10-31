using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_UndergroundCity : MonoBehaviour
{
    //panels
    public RectTransform ui_MissionBoard1;
    public RectTransform ui_MissionBoard2;
    public RectTransform ui_PreparationBoard;
    public RectTransform ui_Dialogue;

    //button on each panel
    public Button btn_MissionBoard;
    public Button btn_Mission1;
    public Button btn_Accept;
    public Button btn_Decline;
    public Button btn_Go;
    public Button btn_Clothes;
    public Button btn_Neuromod;
    public Button btn_Backpack;
    public Button btn_Maps;
    public Button btn_Collections;
    public Button btn_Mission;

    //布局与间距
    public float spacing = 20f;
    public Vector2 ui_MissionBoard1StartPos;

    
    public void Init()
    {
        Hide();
    }

    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }

    void Start()
    {
        //初始：只显示对话面板（NPC点击触发）
        SetActive(ui_Dialogue, true);
        SetActive(ui_MissionBoard1, false);
        SetActive(ui_MissionBoard2, false);
        SetActive(ui_PreparationBoard, false);

        //对话面板：选任务版进入任务版1
        if (btn_MissionBoard) btn_MissionBoard.onClick.AddListener(() =>
            ShowMissionBoard1FromDialog());
        
        if (btn_Mission1) btn_Mission1.onClick.AddListener(ShowMissionBoard2ToRightOf1);

        if (btn_Accept) btn_Accept.onClick.AddListener(ShowPreparationBoardToRightOf2);

    }

    //对话面板 =》任务板1
    void ShowMissionBoard1FromDialog()
    {
        SetActive(ui_Dialogue, false);
        
        ui_MissionBoard1.anchoredPosition = ui_MissionBoard1StartPos;
        SetActive(ui_MissionBoard1, true);

    }

    //任务板1 =》右侧放置任务板2
    void ShowMissionBoard2ToRightOf1()
    {
        PlaceRightOf(ui_MissionBoard2, ui_MissionBoard1, spacing);
        SetActive(ui_MissionBoard2, true);
    }

    //任务板2 =》右侧放置准备面板
    void ShowPreparationBoardToRightOf2()
    {
        PlaceRightOf(ui_PreparationBoard, ui_MissionBoard2, spacing);
        SetActive(ui_PreparationBoard, true);
    }

    //把target摆在reference的右侧（前提：同父级，相同锚点/枢轴） 看不懂啊看不懂
    void PlaceRightOf(RectTransform target, RectTransform reference, float gap)
    {
        float x = reference.anchoredPosition.x + reference.rect.width + gap;
        target.anchoredPosition = new Vector2(x, reference.anchoredPosition.y);
    }

    //小工具：安全开关 依旧不知道干啥的
    void SetActive(RectTransform rt, bool on)
    {
        if (rt && rt.gameObject) rt.gameObject.SetActive(on);
    }

    private void Awake()
    {
       
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
