using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStat : MonoBehaviour
{

    public int enemyMaxHP;
    public int enemyCurrentHP;
    public int enemySpeed;
    public int enemyAtt;
    public float enemyTimeToAttack;
    public float enemyStartTimeToAttack;
    public float turnCountDown;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyTimeToAttack = enemyStartTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTimeToAttack > 0)
        {
            enemyTimeToAttack -= Time.deltaTime;
             
           // Debug.Log(TimeToAttack);
        }
        else
        {
            enemyTimeToAttack = enemyStartTimeToAttack;
        }
        if(enemyCurrentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
