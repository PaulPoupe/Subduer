using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class ArrowGauge : MonoBehaviour, IGauge<float>
{
    [SerializeField] private Transform arrow;
    [Space]
    [SerializeField] private float zeroEngle;
    [SerializeField] private float lastEngle;
    [Space]
    [SerializeField] private float speed;


    private float curentValue = 0.0f;

    private void Start()
    {
        SetValue(-90);
    }

    public IEnumerator Rotate(float requiredValue)
    {
        while (Math.Round(curentValue, 0) != requiredValue)
        {
            if (Overstepping())
            {
                curentValue = requiredValue;
                Rotating();
                yield break;
            }

            else if (curentValue > requiredValue)
            {
                curentValue -= Time.fixedDeltaTime * speed;
                Rotating();
            }
            else if (curentValue < requiredValue)
            {
                curentValue += Time.fixedDeltaTime * speed;
                Rotating();
            }

            yield return null;
        }

        bool Overstepping()
        {
            return Math.Abs(requiredValue - curentValue) <= Time.fixedDeltaTime * speed;
        }

        void Rotating()
        {
            arrow.rotation = quaternion.EulerZXY(curentValue);
        }
    }

    public void SetValue(float value)
    {
        StartCoroutine(Rotate(value));
    }
}