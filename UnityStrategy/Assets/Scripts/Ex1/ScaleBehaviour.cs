using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{
    bool crescer = true;
    public void Animate()
    {
        if(crescer)
        {
            transform.localScale += new Vector3(0.1f,0.1f,0.1f);

            if(transform.localScale.x > 10)
                crescer = false;
        }
        else
        {
            transform.localScale -= new Vector3(0.1f,0.1f,0.1f);

            if(transform.localScale.x < 1)
                crescer = true;
        }
            
    }   
}
