using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRotation : MonoBehaviour
{
    [SerializeField] private float degreesPerSecond = 360;

    private bool m_rotating;
    private int m_dir;

    private void Start()
    {
        RotateClockwise();
    }

    private void FixedUpdate()
    {
        if (m_rotating)
        {
            transform.Rotate(new Vector3(0, 0, degreesPerSecond * Time.deltaTime * m_dir));
        }
    }


    public void RotateClockwise ()
    {
        m_dir = -1;
        m_rotating = true;
    }

    public void RotateCounterclockwise()
    {
        m_dir = 1;
        m_rotating = true;
    }

    public void StopRotation()
    {
        m_rotating = false;
    }
}
