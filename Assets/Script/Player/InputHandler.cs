using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    private PlayerMovement playerMovement;

    
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        
    }

    void Start()
    {
    }

// Update is called once per frame
    void Update()
    {
     HandleInput();   
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.S))
        {
            playerMovement.MoveDown();
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerMovement.MoveUp();
        }
    }
}
