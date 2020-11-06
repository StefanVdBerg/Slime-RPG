using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Action"), menuName = "Action/New Action")]
public class Action : ScriptableObject
{
    public int damage;

    public string name;

    public virtual void Activate(int i)
    {
        Debug.Log(name + " " + damage * i);
    }
}
