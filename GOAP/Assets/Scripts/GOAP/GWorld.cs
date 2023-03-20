using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    private static Queue<GameObject> patients;

    private static Queue<GameObject> cubicles;

    private static Queue<GameObject> admires;
    static GWorld()
    {
        world = new WorldStates();
        patients = new Queue<GameObject>();
        cubicles = new Queue<GameObject>();
        admires = new Queue<GameObject>();

        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cubicle");
        GameObject[] admireobjs = GameObject.FindGameObjectsWithTag("Admire");
        foreach (GameObject c in cubes)
        {
            cubicles.Enqueue(c);
        }
        foreach (GameObject a in admireobjs)
        {
            admires.Enqueue(a);
        }


        if (cubes.Length > 0)
        {
            world.ModifyState("FreeCubicle", cubes.Length);
        }

        if (admireobjs.Length > 0)
        {
            world.ModifyState("FreeAdmires", admireobjs.Length);
        }
        Time.timeScale = 5;
    }

    private GWorld()
    {
    }

    public void AddPatient(GameObject patient)
    {
        
        patients.Enqueue(patient);
    }

    public GameObject RemovePatient()
    {
        if (patients.Count > 0)
        {
            return patients.Dequeue();
        }
        else { return null; }

    }


    public void AddCubicle(GameObject cubicle)
    {
        cubicles.Enqueue(cubicle);
    }

    public GameObject RemoveCubicle()
    {
        if (cubicles.Count > 0)
        {
            return cubicles.Dequeue();
        }
        else { return null; }

    }

    public void AddAdmire(GameObject admire)
    {
        admires.Enqueue(admire);
    }

    public GameObject RemoveAdmire()
    {
        if (admires.Count > 0)
        {
            return admires.Dequeue();
        }
        else { return null; }

    }


    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}
