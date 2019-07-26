using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TestScripts : MonoBehaviour
{
    public Image _im1;
    public Image _im2;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        bool tbool = true;

        while (true)
        {
            float val = (tbool) ? 1f : 0f;
            float val2 = (tbool) ? 0f : 1f;

            _im1.DOFade(val, 2f);
            _im2.DOFade(val2, 2f);
            tbool = !tbool;
            yield return new WaitForSeconds(2.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
