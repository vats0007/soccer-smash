using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int coinCount = 0;
    public static int totalCoins = 0;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        //scoreText.text =
    }
    private void Update()
    {
        scoreText.text = coinCount.ToString("0");
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coins")
        {
            coinCount++;
        }
    }

    private void OnDisable()
    {
        totalCoins += coinCount;
    }


}
