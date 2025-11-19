using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject mc_Stand;
    public GameObject mc_Hurt;
    public GameObject mc_Skill;
    public GameObject mc_Attack;
    public GameObject mc_full;
    

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
