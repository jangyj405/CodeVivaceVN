using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(4f);
        ScreenFader.instance.FadeOut(1f, () =>
        {
            SceneManager.LoadScene(SceneDefines.SceneMainMenu);
        });
    }
}
