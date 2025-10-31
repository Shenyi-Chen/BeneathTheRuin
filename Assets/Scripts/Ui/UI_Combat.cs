using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Combat : MonoBehaviour
{
    public TMP_Text text_round;
    public GameObject hp_HpENY1;
    public GameObject hp_HpENY2;
    public GameObject hp_HpMC;
    public GameObject hp_Robot;
    public GameObject panel_CombatOption;
    public GameObject ui_Item;
    public TMP_Text text_Attack;
    public TMP_Text text_Defence;
    public TMP_Text text_Support;
    public TMP_Text text_Bag;

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
