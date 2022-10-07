using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownLimit : MonoBehaviour
{
    private PlayerControllerX playerControllerScript;
    private Rigidbody playerRb;
    public AudioClip jumpSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground") && !playerControllerScript.gameOver)
        {

            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse );
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }

}
