using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;
    private Vector3 PlayerOrigin;

    // Start is called before the first frame update
    void Start()
    {
        PlayerOrigin = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += new Vector3(1, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(-1, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, -1);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position += new Vector3(0, 0, 1);

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position += new Vector3(0, 1, 0);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position += new Vector3(0, -1, 0);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            player.transform.position = PlayerOrigin;

        }
    }
}
