using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStat : MonoBehaviour
{
    public bool enemyUnit;
    public int currentHP;
    public int maxHP;
    //public int speed;
    public int attack;
    public float timeToAttack;
    public float startTimeToAttack;
    public float turnCountDown;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        timeToAttack = startTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToAttack > 0)
        {
            timeToAttack -= Time.deltaTime;
        }
        else
        {

            timeToAttack = startTimeToAttack;
        }

        if(currentHP <=0)
        {
            Destroy(gameObject);

        }
    }

    
}
