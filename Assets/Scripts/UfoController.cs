
using Unity.VisualScripting;
using UnityEngine;

public class UfoController : MonoBehaviour
{
    private Rigidbody2D missileRigidbody;

    [SerializeField] private Transform leftLaunchZone;

    [SerializeField] private Transform leftSpaceDock;

    [SerializeField] private Transform rightLaunchZone;

    [SerializeField] private Transform rightSpaceDock;

    [SerializeField] private Transform missileTransform;

    private float ufoSpeed;

    private Vector2 ufoDirection;

    private float missileLaunchForce;

    private float launchPower;

    private float maximumLaunchForce;

    [SerializeField] private bool canLaunch;



    private void Awake()
    {
        missileRigidbody = GetComponentInChildren<Rigidbody2D>();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Initialise();
    }


    // Update is called once per frame
    void Update()
    {
        // if the ufo is between the left wand right walls
        if (transform.position.x < leftLaunchZone.position.x || transform.position.x > rightLaunchZone.position.x)
        {
            canLaunch = false;
        }

        else
        {
            canLaunch = true;

            missileTransform.gameObject.SetActive(true);

            missileLaunchForce = launchPower * maximumLaunchForce;
        }
        
        MoveUfo();
    }


    private void FixedUpdate()
    {
        // if we have not launched the missile
        if (canLaunch)
        {
            // then launch the missile
            missileRigidbody.AddForce(Vector2.down * missileLaunchForce);

            missileLaunchForce = 0f;

            canLaunch = false;
        }
    }


    private void Initialise()
    {
        ufoSpeed = 0.75f;

        ufoDirection = Vector2.right;

        missileLaunchForce = 0f;

        maximumLaunchForce = 90f;

        launchPower = 2f;

        canLaunch = false;
    }


    private void MoveUfo()
    {
        if (transform.position.x > rightSpaceDock.position.x)
        {
            ufoDirection = Vector2.left;
        }

        else if (transform.position.x < leftSpaceDock.position.x)
        {
            ufoDirection = Vector2.right;
        }

        transform.Translate(ufoSpeed * Time.deltaTime * ufoDirection);
    }


} // end of class
