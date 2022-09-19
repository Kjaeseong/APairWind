using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }

    public bool A { get; private set; }
    public bool S { get; private set; }
    public bool D { get; private set; }
    public bool F { get; private set; }
    public bool Space { get; private set; }

    private void FixedUpdate() 
    {
        MoveKey();
        ActionKey();
    }

    void MoveKey()
    {
        if(Input.GetKey(KeyCode.UpArrow)) { Up = true; }        else { Up = false; }
        if(Input.GetKey(KeyCode.DownArrow)) { Down = true; }    else { Down = false; }
        if(Input.GetKey(KeyCode.LeftArrow)) { Left = true; }    else { Left = false; }
        if(Input.GetKey(KeyCode.RightArrow)) { Right = true; }  else { Right = false; }
    }

    void ActionKey()
    {
        if(Input.GetKeyDown(KeyCode.A)) { A = true; }           else { A = false; }
        if(Input.GetKeyDown(KeyCode.S)) { S = true; }           else { S = false; }
        if(Input.GetKeyDown(KeyCode.D)) { D = true; }           else { D = false; }
        if(Input.GetKeyDown(KeyCode.Space)) { Space = true; }   else { Space = false; }
    }
    
}
