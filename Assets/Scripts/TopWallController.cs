
using UnityEngine;



public class TopWallController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if the ufo missile hits the ground
        if (collision.transform.CompareTag("MissileBaseAmmo"))
        {
        }
    }


} // end of class
