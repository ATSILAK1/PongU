using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp () 
    {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }
}
