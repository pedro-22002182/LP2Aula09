using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{
    public void Animate()
    {
        transform.Rotate(1,1,1, Space.Self);
    }
}
