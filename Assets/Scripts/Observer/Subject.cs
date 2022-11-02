using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject
{
    List<Observer> observers;

    public void Notify(GameObject obj)
    {
        for(int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify(obj);
        }
    }

    public void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }
}
