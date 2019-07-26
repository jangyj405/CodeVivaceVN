using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class Element : MonoBehaviour
{
    [SerializeField]
    protected SpriteRenderer _displayingImage = null;

    public abstract void DoCommand();
    protected void OnCompleteCommand()
    {
        //update Command Index
    }
}
