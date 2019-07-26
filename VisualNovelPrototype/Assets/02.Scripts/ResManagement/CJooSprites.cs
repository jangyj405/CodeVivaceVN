using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CJooSprites
{
    protected static CJooSprites _instance = null;
    public static CJooSprites instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CJooSprites();
            }
            return _instance;
        }
    }
    protected CJooSprites()
    {
        dictSprites = new Dictionary<string, Sprite>();
    }

    protected Dictionary<string, Sprite> dictSprites = null;

    public void AddToDictionary(KeyValuePair<string, Sprite>[] _keyWithSprite)
    {
        foreach (var item in _keyWithSprite)
        {
            AddToDictionary(item);
        }
    }

    protected void AddToDictionary(KeyValuePair<string, Sprite> _keyWithSprite)
    {
        dictSprites.Add(_keyWithSprite.Key, _keyWithSprite.Value);
    }

    public bool GetSpriteAsKey(string _key, out Sprite oSprite)
    {
        oSprite = null;
        if(dictSprites.Count == 0)
        {
            return false;
        }
        bool isInDict = dictSprites.TryGetValue(_key, out oSprite);
        return isInDict;
    }
}
