using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ToggleInternet : MonoBehaviour
{
    [SerializeField]
    private Toggle _toggle = null;
    [SerializeField]
    private Image urlImages = null;
    // Start is called before the first frame update
    void Start()
    {
        _toggle.isOn = false;
    }

    public void ToggleValueChanged(Toggle _toggle)
    {
        if(_toggle.isOn)
        {
            //Display Url List
            DisplayUrls();
        }
        else
        {
            HideUrls();
            //Hide Url List
        }
    }

    private void DisplayUrls()
    {
        urlImages.DOFillAmount(1f, 0.5f);
    }
    private void HideUrls()
    {
        urlImages.DOFillAmount(0f, 0.5f);
    }

    public void OnClickBtnOpenURL(string _url)
    {
        string targetUrl = "";
        switch(_url)
        {
            case "cafe":
                targetUrl = URLDefines.UrlCafe;
                break;

            case "twitter":
                targetUrl = URLDefines.UrlTwitter;
                break;

            case "facebook":
                targetUrl = URLDefines.UrlFaceBook;
                break;

            default:
                targetUrl = "";
                return;
        }
        Application.OpenURL(targetUrl);
    }
}
