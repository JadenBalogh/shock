using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : CanvasMenu
{
    private static HUD instance;
    public static HUD Instance { get { return instance; } }

    protected override void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        base.Awake();
    }
}
