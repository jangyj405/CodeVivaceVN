using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuControl : SceneControl
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }
    
    public void OnClickBtnNew()
    {
        ScreenFader.instance.FadeOut(1f, () => { SceneManager.LoadScene(SceneDefines.ScenePlayGame); });
    }

    public void OnClickBtnLoad()
    {
        ScreenFader.instance.FadeOut(1f, () => { SceneManager.LoadScene(SceneDefines.SceneLoad); });
    }

    public void OnClickBtnOption()
    {
        ScreenFader.instance.FadeOut(1f, () => { SceneManager.LoadScene(SceneDefines.SceneOption); });
    }

    public void OnClickBtnExtra()
    {
        ScreenFader.instance.FadeOut(1f, () => { SceneManager.LoadScene(SceneDefines.SceneExtra); });
    }

    public void OnClickBtnShop()
    {
        ScreenFader.instance.FadeOut(1f, () => { SceneManager.LoadScene(SceneDefines.SceneShop); });
    }
}
