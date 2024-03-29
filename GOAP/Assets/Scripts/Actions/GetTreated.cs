﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTreated : GAction
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

        GWorld.Instance.GetWorld().ModifyState("FreeCubicle", 1);

        GWorld.Instance.AddCubicle(target);
        beliefs.ModifyState("healthy", 1);
        GWorld.Instance.GetWorld().ModifyState("Treated", 1);
        inventory.RemoveItem(target);
        return true;
    }
}
