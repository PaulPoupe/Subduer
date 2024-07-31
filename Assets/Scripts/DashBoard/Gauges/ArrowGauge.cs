using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class ArrowGauge : MonoBehaviour, IGauge<float>
{
    private enum XYZ
    {
        x,
        y,
        z
    }

    [SerializeField] private Transform arrow;
    [Space]
    [SerializeField] private float startEngle;
    [SerializeField] private float finishEngle;
    [SerializeField] private XYZ coordinates;
    [Space]
    [SerializeField] private float speed;

    private Quaternion startQuaternion;
    private Quaternion finishQuaternion;

    private float curentValue = 0.0f;


    public void Initialize()
    {
        startQuaternion = new Quaternion();
        finishQuaternion = new Quaternion();

        switch (coordinates)
        {
            case XYZ.x:
                startQuaternion = quaternion.Euler(startEngle, arrow.rotation.y, arrow.rotation.z);
                finishQuaternion = quaternion.Euler(finishEngle, arrow.rotation.y, arrow.rotation.z);
                break;

            case XYZ.y:
                startQuaternion = quaternion.Euler(arrow.rotation.x, startEngle, arrow.rotation.z);
                finishQuaternion = quaternion.Euler(arrow.rotation.x, finishEngle, arrow.rotation.z);
                break;

            case XYZ.z:
                startQuaternion = quaternion.Euler(arrow.rotation.x, arrow.rotation.y, startEngle);
                finishQuaternion = quaternion.Euler(arrow.rotation.x, arrow.rotation.y, finishEngle);
                break;
        }
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
            arrow.rotation = Quaternion.Lerp(startQuaternion, finishQuaternion, curentValue);
        }
    }

    public void SetValue(float value)
    {
        StartCoroutine(Rotate(value));
    }
}