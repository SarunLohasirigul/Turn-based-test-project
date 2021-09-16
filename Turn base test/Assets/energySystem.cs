using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energySystem : MonoBehaviour
{

    public float currentEnergy;
    public float maxEnergy;
    public int skillDamage;

    characterStat charStat;
    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentEnergy);

        if(currentEnergy >= maxEnergy)
        {
            currentEnergy = maxEnergy;
        }
        else
        {
            currentEnergy += Time.deltaTime;
        }


    }
    
}
