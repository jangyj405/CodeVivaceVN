using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using System.Reflection;



public static class Values
{
    public static float speed = 1f;
}


public class ElementInWorld : Element
{
    protected Vector3 originScale = Vector3.one;

    public override void DoCommand()
    {
        //Move(Vector3.left);
        //FadeOut();
    }
    public  void DoCommand1()
    {
       // transform.position = new Vector3(-1f, -2.5f, 0f);
       // Move(new Vector3(-1f,-3f,0f));
       // ChangeScale(2f);
       // FadeIn();
     
    }

    IEnumerator TestMove()
    {
        Vector3 target = transform.position + Vector3.right * 3f;
        FadeOut(Vector3.right);
        yield return new WaitForSeconds(1.1f);
        transform.position = target;
        yield return new WaitForSeconds(1.1f);
        FadeIn(Vector3.right);
    }


    void TestFadeOut()
    {
        FadeOut(Vector3.right);
    }

    void TestFadeIn()
    {
        FadeIn(Vector3.right);
    }
    
    IEnumerator TestZoom()
    {
        FadeOut(Vector3.zero);
        yield return new WaitForSeconds(1.1f);
        ChangeScale(2f);
        transform.position = new Vector3(-3f, -4f, 0f);
        FadeIn(Vector3.zero);
    }

    void TestCrossFade()
    {

    }

    void asdf()//Start()
    {
        Tween tTween = transform.DOMove(Vector3.up * 5, 3f);
        tTween.Kill(true);
        //tTween.Complete();
        //Action complete = delegate () { transform.position = Vector3.up; }; 
    }

    void TestShakeSide()
    {

    }

    void TestReset()
    {
        transform.localScale = originScale;
        transform.position = Vector3.zero;
    }

    protected virtual void Shake_Updown()
    {
        transform.DOShakePosition(1f, strength: Vector3.up * 0.5f, vibrato: 4, randomness: 0f).SetEase(Ease.InBounce);
    }

    protected virtual void Shake_Side()
    {
        transform.DOShakePosition(1f,strength:Vector3.right * 0.5f, vibrato: 4, randomness:0f).SetEase(Ease.InBounce);
        
        
    }
    [SerializeField]
    Sprite _sprite;
    protected virtual void Crossfade()
    {
        SpriteRenderer _renderer = Instantiate<SpriteRenderer>(_displayingImage, this.transform);
        _renderer.sprite = _sprite;
        _renderer.color = new Color(1f, 1f, 1f, 0f);
        Tween tTween = _displayingImage.DOFade(0f, 1f);
        _renderer.DOFade(1f, 1f).OnComplete(()=> 
        {

            Destroy(_displayingImage.gameObject);
            _displayingImage = _renderer;

        });
        
    }

    protected virtual void ChangeScale(float _scalar)
    {
        transform.localScale = originScale * _scalar;
    }

    protected virtual void Move(Vector3 _vec)
    {
        transform.DOMove(_vec, Values.speed * 2f);
    }

   
    protected virtual void FadeOut(Vector3 _dir)
    {
        _dir = _dir.normalized;
        transform.DOMove(_dir + transform.position, 1f);
        _displayingImage.DOFade(0f, Values.speed);
    }
   
    protected virtual void FadeIn(Vector3 _dir)
    {
        _dir = _dir.normalized;
        transform.position -= _dir;
        transform.DOMove(_dir + transform.position, 1f);
        _displayingImage.DOFade(1f, Values.speed);
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(0f,0f,100f,100f),"asdf"))
        {
            //DoCommand();
            StartCoroutine(TestZoom());
            //TestFadeIn();
        }
        if (GUI.Button(new Rect(100f, 0f, 100f, 100f), "asdf"))
        {
            //Shake_Side();
            Crossfade( 
                );
        }

        
    }
}