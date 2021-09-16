using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{

    public characterStat CharaStat;
    public enemyStat EneStat;
    public GameObject PlayerUnit;
    public GameObject EnemyUnit;

    public energySystem enSystem;

    
    


    Unit playerUnit;

    // Start is called before the first frame update
    void Start()
    {
        CharaStat = GameObject.Find("player").GetComponent<characterStat>();
        EneStat = GameObject.Find("enemy").GetComponent<enemyStat>();
        enSystem = GameObject.Find("energy").GetComponent<energySystem>();

        
    }

    // Update is called once per frame
    void Update()
    {
        battleUI.instance.PlayerHp(CharaStat);
        battleUI.instance.EnemyHp(EneStat);
        if (CharaStat.timeToAttack <= 0)
        {
            EneStat.enemyCurrentHP -= CharaStat.attack;
            
        }
        if(EneStat.enemyTimeToAttack <= 0)
        {
            CharaStat.currentHP -= EneStat.enemyAtt;
            
        }
    }

    public void OnSkillClick()
    {
        if( enSystem.currentEnergy >= 3)
        {
            enSystem.currentEnergy -= 3;
            EneStat.enemyCurrentHP -= enSystem.skillDamage;

        }
    }
}
