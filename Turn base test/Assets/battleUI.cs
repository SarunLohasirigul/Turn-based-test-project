using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleUI : MonoBehaviour
{


    public static battleUI instance;
    public Text energyCount;
    public Text PlayerHP;
    public Text EnemyHP;
    public energySystem EnSys;


    private void Awake()
    {
        instance = this;
        EnSys = GameObject.Find("energy").GetComponent<energySystem>();
    }
    public void Update()
    {
        energyCount.text = "En : " + EnSys.currentEnergy.ToString();
    }
   /* public void energyUI(energySystem EnSys)
    {
        energyCount.text = "En : " + EnSys.currentEnergy.ToString();
    }*/
   
    public void PlayerHp(characterStat charStat)
    {
        PlayerHP.text = "Hp : " + charStat.currentHP.ToString();
    }

    public void EnemyHp(enemyStat eneStat)
    {
        EnemyHP.text = "Hp : " + eneStat.enemyCurrentHP.ToString();
    }
}
