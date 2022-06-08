using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
        }

        transform.position = Input.mousePosition;
    }
}
