using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoCubicle : GAction
{
    public override bool PrePerform()
    {
        target = inventory.FindItemWithTag("Cubicle");
        if (target == null)
        {
            return false;
        }

        return true;
    }

    public override bool PostPerform()
    {
        /*
        GWorld.Instance.GetWorld().ModifyState("FreeCubicle", 1);

        GWorld.Instance.AddCubicle(target);
        */
        beliefs.ModifyState("Energy", -1);
        beliefs.ModifyState("work", 1);
        inventory.RemoveItem(target);
        return true;
    }
}
