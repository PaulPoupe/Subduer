using System;
using System.Collections;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public static DateTime dateTime = new(1982, 7, 23);

    private IEnumerator TimeCoroutine()
    {
        while (true)
        {
            dateTime = dateTime.AddMinutes(1);
            yield return new WaitForSeconds(10);
        }
    }

    public void StartClock()
    {
        StartCoroutine(TimeCoroutine());
    }
}