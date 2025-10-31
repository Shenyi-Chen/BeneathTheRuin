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

    //��������
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
        //��ʼ��ֻ��ʾ�Ի���壨NPC���������
        SetActive(ui_Dialogue, true);
        SetActive(ui_MissionBoard1, false);
        SetActive(ui_MissionBoard2, false);
        SetActive(ui_PreparationBoard, false);

        //�Ի���壺ѡ�������������1
        if (btn_MissionBoard) btn_MissionBoard.onClick.AddListener(() =>
            ShowMissionBoard1FromDialog());
        
        if (btn_Mission1) btn_Mission1.onClick.AddListener(ShowMissionBoard2ToRightOf1);

        if (btn_Accept) btn_Accept.onClick.AddListener(ShowPreparationBoardToRightOf2);

    }

    //�Ի���� =�������1
    void ShowMissionBoard1FromDialog()
    {
        SetActive(ui_Dialogue, false);
        
        ui_MissionBoard1.anchoredPosition = ui_MissionBoard1StartPos;
        SetActive(ui_MissionBoard1, true);

    }

    //�����1 =���Ҳ���������2
    void ShowMissionBoard2ToRightOf1()
    {
        PlaceRightOf(ui_MissionBoard2, ui_MissionBoard1, spacing);
        SetActive(ui_MissionBoard2, true);
    }

    //�����2 =���Ҳ����׼�����
    void ShowPreparationBoardToRightOf2()
    {
        PlaceRightOf(ui_PreparationBoard, ui_MissionBoard2, spacing);
        SetActive(ui_PreparationBoard, true);
    }

    //��target����reference���Ҳࣨǰ�᣺ͬ��������ͬê��/���ᣩ ��������������
    void PlaceRightOf(RectTransform target, RectTransform reference, float gap)
    {
        float x = reference.anchoredPosition.x + reference.rect.width + gap;
        target.anchoredPosition = new Vector2(x, reference.anchoredPosition.y);
    }

    //С���ߣ���ȫ���� ���ɲ�֪����ɶ��
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
