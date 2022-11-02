using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Observer
{
    public abstract void OnNotify(GameObject obj);
}

public class Destroyed : Observer
{
    GameObject destroyedObject;

    public Destroyed(GameObject destroyedObject)
    {
        this.destroyedObject = destroyedObject;
    }

    public override void OnNotify(GameObject obj)
    {
        Debug.Log("Destroyed");
    }
}