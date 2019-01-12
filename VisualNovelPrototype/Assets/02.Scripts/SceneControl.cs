using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        ScreenFader.instance.FadeIn(1.5f);
    }
}
