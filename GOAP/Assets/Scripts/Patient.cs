using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();


        SubGoal s0 = new SubGoal("isWaiting", 1, true);
        goals.Add(s0, 2);


        SubGoal s1 = new SubGoal("isTreated", 1, true);
        goals.Add(s1, 5);

        SubGoal s2 = new SubGoal("returned", 1, true);
        goals.Add(s2, 3);

        float rand = Random.value;

        if (rand < .5f)
        {
            SubGoal s3 = new SubGoal("admire", 1, true);
            goals.Add(s3, 4);

        }
        else
        {

        }
    }

}
