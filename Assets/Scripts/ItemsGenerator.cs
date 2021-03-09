using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private GameObject sphere;

    [SerializeField]
    private Vector2 countCubes;

    [SerializeField]
    private Vector2 countSpheres;

    [SerializeField]
    private Transform cubeParent;

    [SerializeField]
    private Transform sphereParent;

    [SerializeField]
    private float indent;

    [SerializeField]
    private float rotateSpeed;

    private List<List<GameObject>> cubes;
    private List<List<GameObject>> spheres;

    private Vector3 startCubesPosition;
    private Vector3 startSpheresPosition;

    private void Start()
    {
        cubes = new List<List<GameObject>>();
        spheres = new List<List<GameObject>>();

        startCubesPosition = cubeParent.position;
        startSpheresPosition = sphereParent.position;

        for (int i = 0; i < countCubes.y; i++)
        {
            cubes.Add(new List<GameObject>());
            for (int j = 0; j < countCubes.x; j++)
            {
                cubes[i].Add(Instantiate(cube, cubeParent));
                cubes[i][j].transform.position = new Vector3(j * indent + startCubesPosition.x, startCubesPosition.y, i * indent + startCubesPosition.z);
            }
        }

        for (int i = 0; i < countSpheres.y; i++)
        {
            spheres.Add(new List<GameObject>());
            for (int j = 0; j < countSpheres.x; j++)
            {
                spheres[i].Add(Instantiate(sphere, sphereParent));
                spheres[i][j].transform.position = new Vector3(j * indent + startSpheresPosition.x, startSpheresPosition.y, i * indent + startSpheresPosition.z);
            }
        }
    }

    private void RotateCubes()
    {
        for (int i = 0; i < countCubes.y; i++)
        {
            for (int j = 0; j < countCubes.x; j++)
            {
                cubes[i][j].transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
                cubes[i][j].transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed / 2);
            }
        }
    }

    private void Update()
    {
        RotateCubes();
    }
}
