using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public Combat combat;
    public UndergroundCity undergroundCity;
    public Character character;
    private void Awake()
    { 
        I = this;
        combat.Init();
        //undergroundCity.Init();







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
