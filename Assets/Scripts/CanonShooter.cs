using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShooter : MonoBehaviour
{
    [SerializeField] private GameObject canonBall;
    [SerializeField] private Transform shotPoint;
    public float shotPower;
    public int ballLeft;

    private void Start()
    {
        ballLeft = 10;
    }
    // Update is called once per frame
    void Update()
    {
        if (ballLeft > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject newCanonBall = Instantiate(canonBall, shotPoint.position, shotPoint.rotation);
                ballLeft--;
                newCanonBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, shotPower), ForceMode.Impulse);
            }
        } 
    }

    public int GetBallLeft()
    {
        return ballLeft;
    }
}
