using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float orbitSpeed = 14.0f;

    void Update()
    {
        // Rotate the empty GameObject around its y-axis
        transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime);
    }
}