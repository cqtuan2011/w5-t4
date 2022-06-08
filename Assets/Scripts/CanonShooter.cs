using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanonShooter : MonoBehaviour
{
    [SerializeField] private GameObject canonBall;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private Slider powerBar;

    public float sensitivity;
    private float shotPower;
    public int ballLeft;

    private void Start()
    {
        ballLeft = 10;
    }
    // Update is called once per frame
    void Update()
    {
        ChargePowerBar();
        ReleaseCharge();
    }

    void ChargePowerBar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            powerBar.value += Time.deltaTime * sensitivity;
        }
    }

    void ReleaseCharge()
    {
        if (ballLeft > 0)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                GameObject newCanonBall = Instantiate(canonBall, shotPoint.position, shotPoint.rotation);
                ballLeft--;
                newCanonBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, powerBar.value), ForceMode.Impulse);
                powerBar.value = 0; 
            }
        }
    }

    public int GetBallLeft()
    {
        return ballLeft;
    }
}
