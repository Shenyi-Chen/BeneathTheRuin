using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Loading : MonoBehaviour
{
    public Button btn_Play;
    public Button btn_NewGame;
    public Button btn_Setting;
    public Button btn_Quit;

    public void Init()
    {
        Show();


        btn_Play.onClick.AddListener(() =>
        {
            Hide();
            //Go to Combate Scene.===TODO

            //UIMgr.I.Ui
    



        });

        btn_NewGame.onClick.AddListener(() =>
        {
            Hide();
        });



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
