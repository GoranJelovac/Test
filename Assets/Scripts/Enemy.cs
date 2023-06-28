using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public FloatReference MaxHP;
    public FloatReference MoveSpeed;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("HP: " + MaxHP.Value);
            Debug.Log(("MoveSpeed: " + MoveSpeed.Value));
        }
    }

}
