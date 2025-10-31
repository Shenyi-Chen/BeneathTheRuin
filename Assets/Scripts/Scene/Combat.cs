using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public GameObject mc_Stand;
    public GameObject mc_Hurt;
    public GameObject mc_Skill;
    public GameObject mc_Attack;
    public GameObject mc_full;
    public GameObject mc_DefenceEffect;
    public GameObject enemy1;
    public GameObject enemy1_Attacked;
    public GameObject enemy2;
    public GameObject enemy2_Attacked;
    public GameObject robot;
    public GameObject robot_Selected;
    public GameObject eny1_AttackEffect;
    public GameObject remoteSupportEffect;

  
    
    public void Init() 
    {
        Hide();
    }

    public void Show() { gameObject.SetActive(true); }
    public void Hide() { gameObject.SetActive(false); }






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
