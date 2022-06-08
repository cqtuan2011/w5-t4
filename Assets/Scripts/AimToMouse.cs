using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimToMouse : MonoBehaviour
{
    [SerializeField] Transform canonBarrel;

    private void FixedUpdate()
    {
        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition); // return ray from screen to mouse position
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, out hitInfo)) // output hit information to hitInfo 
        {
            if (hitInfo.collider != null) // hit something
            {
                Vector3 dir = hitInfo.point - canonBarrel.position;

                canonBarrel.rotation = Quaternion.LookRotation(dir);

            }
        }
    }
}
