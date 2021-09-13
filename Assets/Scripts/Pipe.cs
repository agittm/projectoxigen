using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static System.Action OnHitPipe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnHitPipe?.Invoke();
    }
}
