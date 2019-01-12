using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    //for using this script as singletone
    public static ScreenFader instance = null;

    //Fading Image
    [SerializeField]
    protected Image fdImage = null;
    public void FadeIn(float _time)
    {
        fdImage.gameObject.SetActive(true);
        Tweener tTween = fdImage.DOFade(0f, _time);
        tTween.OnComplete(() => { fdImage.gameObject.SetActive(false); });
    }
    public void FadeOut(float _time, System.Action _callback = null)
    {
        fdImage.gameObject.SetActive(true);
        Tweener tTween = fdImage.DOFade(1f, _time);
        tTween.OnComplete(() =>
        {
            if (_callback != null)
            {
                _callback();
            }
            else
            {
                return;
            }
        });
    }
    public void BlackOutScreen()
    {
        fdImage.color = Color.black;
    }
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
