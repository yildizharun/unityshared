using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager :MonoBehaviour
{
    private static InputManager instance;

    public static InputManager Instance{
        get
        {
            return instance;
        }
    }
    private void Awake() 
    {
        if(Instance==null)
        {
            instance=this;
        }
    }

    public float getXDirection()
    {
        float x = Input.GetAxisRaw("Horizontal");
        return x;
    }
}
