using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpawn : MonoBehaviour
{
     public int height = 10;
     public int width = 10;
     public GameObject cubePrefab;
     public GameObject player;
    private GameObject[,] grid;
    //private List<string> bridsList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        List<string> birds = new List<string>();
        birds.Add("Parrot");
        birds.Add("Crow");
        birds.Add("Hawk");
        birds.Add("Dove");
        birds.Add("Pigeon");
        birds.Add("Eagle");



        grid = new GameObject[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {

                grid[x, z] = Instantiate(cubePrefab, new Vector3(x * 2, 0, z * 2), Quaternion.identity);
                grid[x, z].GetComponentInChildren<TextMesh>().text = birds[Random.Range(0, birds.Count)];

            }
        }
    }

}

