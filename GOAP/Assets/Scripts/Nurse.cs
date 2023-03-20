using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse : GAgent
{

    public int startEnergy = 5;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("treatPatient", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("Energetic", 1 , false);
        goals.Add(s2, 10);
        beliefs.ModifyState("Energy", startEnergy);
        beliefs.ModifyState("work", 5 - startEnergy);
    }

}
