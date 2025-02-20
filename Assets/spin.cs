using UnityEngine;

public class spin : MonoBehaviour
{
    public float variable_time = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, variable_time * Time.deltaTime, 0f, Space.Self);
    }
}
