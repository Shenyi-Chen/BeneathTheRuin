using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CombatResult : MonoBehaviour
{
    public GameObject panel_CombatEquipmentSituation;
    public GameObject panel_CombarResult;
    public Button btn_ViewStatus;

    public void Init()
    {
        Hide();

    }
    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }

    private void Awake()
    {

    }

    void start()
    {
        btn_ViewStatus.onClick.AddListener(ViewStatus);

        panel_CombatEquipmentSituation.gameObject.SetActive(false);
    }

    void ViewStatus()
    {
        panel_CombatEquipmentSituation.gameObject.SetActive(true);
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
