using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command 
{
    protected string _commandType = "";

    public virtual void DoCommand()
    {

    }

    protected void UpdateCommandIndex()
    {

    }

    protected void JumpToCommand(string _label)
    {

    }

    protected void WaitForTouch()
    {
        //
    }
}
