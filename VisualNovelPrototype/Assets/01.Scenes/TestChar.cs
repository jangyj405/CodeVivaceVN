using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TestChar : MonoBehaviour
{
    bool isFacingFront = true;
    public GameObject imageFront;
    public GameObject imageBack;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        /*
        imageBack.SetActive(false);
        Tween tTween = gameObject.transform.DORotate(Vector3.up * 180f, 1f);
        yield return new WaitForSeconds(0.3f);
        imageBack.SetActive(true); imageFront.SetActive(false);
        //tTween.OnComplete(() => { imageBack.SetActive(true); imageFront.SetActive(false); });
        */
        gameObject.transform.DOMoveX(-5f, 0.2f).SetEase(Ease.Linear);
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
