
using UnityEngine;

public class UfoController : MonoBehaviour
{
    private float ufoSpeed;

    private Vector2 ufoDirection;

    private float leftBoundary;

    private float rightBoundary;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Initialise();
    }


    // Update is called once per frame
    void Update()
    {
        MoveUfo();
    }


    private void Initialise()
    {
        ufoSpeed = 0.75f;

        ufoDirection = Vector2.right;

        leftBoundary = -11f;

        rightBoundary = 11f;
    }


    private void MoveUfo()
    {
        if (transform.position.x > rightBoundary)
        {
            ufoDirection = Vector2.left;
        }

        else if (transform.position.x < leftBoundary)
        {
            ufoDirection = Vector2.right;
        }

        transform.Translate(ufoSpeed * Time.deltaTime * ufoDirection);
    }

} // end of class
