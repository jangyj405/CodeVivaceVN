using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayLogosControl : MonoBehaviour
{
    IEnumerator Start()
    {
        ScreenFader.instance.FadeIn(1.5f);
        yield return new WaitForSeconds(2.5f);
        ScreenFader.instance.FadeOut(2f, () =>
        {
            SceneManager.LoadScene(SceneDefines.SceneMainMenu);
        });
    }
}
