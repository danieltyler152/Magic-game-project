using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Portal2controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame

    public GameObject Portal2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("You pressed T");

        }
        if (Input.GetKey(KeyCode.O))
        {
            Portal2.transform.Translate(0, (float)0.01, 0);
            // Up
        }
        if (Input.GetKey(KeyCode.U))
        {
            Portal2.transform.Translate(0, (float)-0.01, 0);
            // Down
        }
        if (Input.GetKey(KeyCode.J))
        {
            Portal2.transform.Translate((float)0.01, 0, 0);
            // Right
        }
        if (Input.GetKey(KeyCode.L))
        {
            Portal2.transform.Translate((float)-0.01, 0, 0);
            // Left
        }
        if (Input.GetKey(KeyCode.I))
        {
            Portal2.transform.Translate(0, 0, (float)0.01);
            // Forwards
        }
        if (Input.GetKey(KeyCode.K))
        {
            Portal2.transform.Translate(0, 0, (float)-0.01);
            // Backwards
        }
    }
}
