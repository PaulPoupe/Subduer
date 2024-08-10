using System;
using UnityEngine;

namespace EntryPoint
{
    internal abstract class EntryPoint : MonoBehaviour
    {
        public static Action<bool> OnStateUpdated;
    }

}