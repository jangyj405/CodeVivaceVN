using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Template : MonoBehaviour
{
    private Dictionary<string, Sprite> _spritesDict = null;

    [SerializeField]
    private List<Sprite> _spritesList = null;

    public void InitialTemplate()
    {
        if(_spritesList.Count == 0)
        {
            return;
        }
        foreach(var item in _spritesList)
        {
            _spritesDict.Add(item.name, item);
            
        }
    }

    /// <summary>
    /// Fade in sprite.
    /// </summary>
    /// <param name="_dir">Fade in from _dir.</param>
    public void FadeIn(Vector3 _dir)
    {

    }

    /// <summary>
    /// Fade out sprite.
    /// </summary>
    /// <param name="_dir">Fade out to _dir.</param>
    public void FadeOut(Vector3 _dir)
    {

    }



}
