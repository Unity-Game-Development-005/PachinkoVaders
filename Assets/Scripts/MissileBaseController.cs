
using UnityEngine;



public class MissileBaseController : MonoBehaviour
{
    [SerializeField] private Transform missileBaseMissile;

    [SerializeField] private int missileBaseIndex;

    private float missileBaseSpeed;

    private Vector2 missileBaseDirection;

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
        MoveMissileBase();
    }


    private void Initialise()
    {
        switch (missileBaseIndex)
        {
            case 1:

                missileBaseSpeed = 0.25f;

                break;

            case 2:

                missileBaseSpeed = 0.35f;

                break;

            case 3:

                missileBaseSpeed = 0.45f;

                break;
        }

        missileBaseDirection = Vector2.right;

        leftBoundary = transform.position.x -1f;

        rightBoundary = transform.position.x + 1f;
    }


    private void MoveMissileBase()
    {
        if (transform.position.x > rightBoundary)
        {
            missileBaseDirection = Vector2.left;
        }

        else if (transform.position.x < leftBoundary)
        {
            missileBaseDirection = Vector2.right;
        }

        transform.Translate(missileBaseSpeed * Time.deltaTime * missileBaseDirection);
    }


} // end of class
