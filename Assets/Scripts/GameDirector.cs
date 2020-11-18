using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : System.Object
{
    private static GameDirector _instance;             //导演类的实例
    public ISceneController CurrentScenceController { get; set; }
    public static GameDirector GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameDirector();
        }
        return _instance;
    }
}