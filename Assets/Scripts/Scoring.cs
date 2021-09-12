using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static System.Action OnAddScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnAddScore?.Invoke();
    }
}
