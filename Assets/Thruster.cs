using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Thruster : MonoBehaviour
{
    [SerializeField, Tooltip("Base amount of force to add per second")] 
    private float baseThrust = 5f;
    [SerializeField, Range(1f, 3f), Tooltip("Multiplier to apply to thrust while boosting")] 
    private float boostMultiplier = 2f;
    [SerializeField, Range(0f, 5f), Tooltip("Time allowed to boost")] 
    private float boostTime;

    private Rigidbody2D m_rb2d;
    private bool m_thrusting;
    private bool m_boosting;

    private void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();

        Thrust();
    }

    private void FixedUpdate()
    {
        if (m_thrusting)
        {
            m_rb2d.AddForce(transform.up * baseThrust * (m_boosting ? boostMultiplier : 1) * Time.deltaTime);
        }
    }

    public void Thrust ()
    {
        m_thrusting = true;
    }

    public void StopThrust ()
    {
        m_thrusting = true;
    }
}
