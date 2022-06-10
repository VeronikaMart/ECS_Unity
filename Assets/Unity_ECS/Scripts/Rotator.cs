using UnityEngine;

namespace ECS_Unity
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Update()
        {
            transform.Rotate(0f, speed * Time.deltaTime, 0f);
        }
    }
}