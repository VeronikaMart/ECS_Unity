using Unity.Entities;
using UnityEngine;

namespace ECS_Unity
{
    public class RotatorSystem : ComponentSystem
    {
        struct Components
        {
            public RotatorECS rotator;
            public Transform transform;
        }

        // Use instead of Update
        protected override void OnUpdate()
        {
            var deltaTime = Time.DeltaTime;

            // Search for all objects we want to update 
            Entities.ForEach((RotatorECS rotator, Transform transform) =>
            {
                rotator.transform.Rotate(0f, rotator.speed * deltaTime, 0f);
            });
        }
    }
}