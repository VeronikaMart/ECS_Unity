using UnityEngine;

namespace ECS_Unity
{
    public class CubeCreator : MonoBehaviour
    {
        [SerializeField] private GameObject cube;
        [SerializeField] private int numberOfCubes = 100;
        [SerializeField] private int offset = 30;

        private void Update()
        {
            // Generate cubes
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < numberOfCubes; i++)
                {
                    Instantiate(cube);
                    cube.transform.position = Random.insideUnitSphere * offset;
                }
            }
        }
    }
}