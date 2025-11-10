using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject Portal1;
    public GameObject Portal2;
    public bool cooldown;

    private void OnTriggerEnter(Collider collision) 
    {
        if ((collision.gameObject == Portal1 && !cooldown))
        {
            this.gameObject.transform.position = Portal2.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
        else if ((collision.gameObject == Portal2 && !cooldown))
        {
            this.gameObject.transform.position = Portal1.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
    }
    public IEnumerator timer()
    {
        yield return new WaitForSeconds((float)0.5);
        cooldown = false;
    }
}