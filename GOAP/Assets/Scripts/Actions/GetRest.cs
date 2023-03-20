using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRest : GAction
{
    public override bool PrePerform()
    {

        return true;
    }

    public override bool PostPerform()
    {

        beliefs.ModifyState("Energy", +5);
        beliefs.ModifyState("work", -5);

        return true;
    }
}
