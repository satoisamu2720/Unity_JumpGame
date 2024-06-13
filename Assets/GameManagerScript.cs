using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public GameObject block;
    public GameObject goal;

    // Start is called before the first frame update
    void Start()
    {
        
        int[,] map =
        {

            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1}, 
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1}, 
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,1,1,1, 0,0,0,0,0,0,0,0,0,0, 1,1,1,0,0,0,0,2,0,1}, 
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,1,1,1,0, 0,0,0,0,0,0,1,1,1,1}, 
            {1,0,0,0,0,0,0,0,0,1, 1,1,0,0,1,1,1,0,0,0, 0,0,1,1,1,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1}, 
            {1,0,0,0,0,1,1,1,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,1,0,0,0,0,1}, 
            {1,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1, 1,1,1,1,1,1,1,1,1,1, 1,1,1,1,1,1,1,1,1,1, 1,1,1,1,1,1,1,1,1,1},

        };
        int lenY = map.GetLength(0); 
        int lenX = map.GetLength(1); 

        for (int x = 0; x < map.GetLength(1); x++) 
        { 
            for(int y = 0; y < map.GetLength(0); y++)
            {
                Vector3 position = Vector3.zero;
                position.x = x;
                position.y = -y+5;
                if (map[y, x] == 1)
                {
                    Instantiate(block, position, Quaternion.identity);
                }

                if (map[y, x] == 2)
                {
                    goal.transform.position = position;
                }
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalScript.isGameClear == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
