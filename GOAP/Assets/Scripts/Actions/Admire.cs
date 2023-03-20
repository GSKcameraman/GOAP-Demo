using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admire : GAction
{
    GameObject resource;
    public override bool PrePerform()
    {
        

        resource = GWorld.Instance.RemoveAdmire();
        


        
        if (resource == null)
        {
            //beliefs.ModifyState("admire", 1);
            
            return false;
        }
        target = resource;
        //inventory.AddItem(target);

        GWorld.Instance.GetWorld().ModifyState("FreeAdmires", -1);



        return true;

    }

    public override bool PostPerform()
    {




        GWorld.Instance.GetWorld().ModifyState("FreeAdmires", 1);
        GWorld.Instance.AddAdmire(resource);




        /*
        GWorld.Instance.GetWorld().ModifyState("waiting", 1);
        GWorld.Instance.AddPatient(this.gameObject);
        beliefs.ModifyState("atHospital", 1);*/
        //GWorld.Instance.AddAdmire(target);

        //inventory.RemoveItem(target);

        //GWorld.Instance.AddPatient(this.gameObject);
        return true;
    }
}
