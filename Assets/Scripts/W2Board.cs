using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2Board : MonoBehaviour
{
    public GameObject player;
    private Vector3 PlayerOrigin;
    private Vector3[] HazardOrigin;
    public Transform[] hazard;
    AudioSource audPlayer;
    public AudioClip moveClip, hazardClip;
    public GameObject posTile;
    public GameObject posTile2;
    public GameObject posTile3;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerOrigin = player.transform.position;
        audPlayer = GetComponent<AudioSource>();


        for (int i = 0; i < hazard.Length; i++)
        {
            HazardOrigin[i] = hazard[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += new Vector3(1, 0, 0);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(-1, 0, 0);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, -1);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position += new Vector3(0, 0, 1);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position += new Vector3(0, 1, 0);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position += new Vector3(0, -1, 0);
            audPlayer.PlayOneShot(moveClip);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            player.transform.position = PlayerOrigin;
            audPlayer.PlayOneShot(hazardClip);
            //hazard.position = HazardOrigin;

        }

        for (int i = 0; i < hazard.Length; i++)
        {
            if (hazard[i].position == player.transform.position)
            {
                player.transform.position = PlayerOrigin;
                audPlayer.PlayOneShot(hazardClip);
                
            }
        }

        if (posTile.transform.position + new Vector3(0, 1, 0) == player.transform.position)
        {
            posTile.GetComponent<Renderer>().material.color = Color.red;
        }

        if (posTile2.transform.position + new Vector3(0, 1, 0) == player.transform.position)
        {
            posTile2.GetComponent<Renderer>().material.color = Color.red;
        }

        if (posTile3.transform.position + new Vector3(0, 1, 0) == player.transform.position)
        {
            posTile3.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}

