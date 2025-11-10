using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Portal1controller: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame

    public GameObject Portal1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("You pressed T");

        }
        if (Input.GetKey(KeyCode.Y))
        {
            Portal1.transform.Translate(0, (float)0.01, 0);
            // Up
        }
        if (Input.GetKey(KeyCode.R))
        {
            Portal1.transform.Translate(0, (float)-0.01, 0);
            // Down
        }
        if (Input.GetKey(KeyCode.H))
        {
            Portal1.transform.Translate((float)0.01, 0, 0);
            // Right
        }
        if (Input.GetKey(KeyCode.F))
        {
            Portal1.transform.Translate((float)-0.01, 0, 0);
            // Left
        }
        if (Input.GetKey(KeyCode.T))
        {
            Portal1.transform.Translate(0, 0, (float)0.01);
            // Forwards
        }
        if (Input.GetKey(KeyCode.G))
        {
            Portal1.transform.Translate(0, 0, (float)-0.01);
            // Backwards
        }
    }
}
