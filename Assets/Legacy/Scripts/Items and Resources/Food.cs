using UnityEngine;

namespace ItemsAndResources
{
    [CreateAssetMenu(fileName = "Food", menuName = "Items/Food")]
    public class Food : Item
    {
        [field: SerializeField]
        public int calorie { get; private set; }
    }
}