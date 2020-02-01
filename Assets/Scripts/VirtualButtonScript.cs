using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject bullet;
    [SerializeField]
    private float speed = 10f;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Hello World");
        GameObject tempBullet = Instantiate(bullet, bullet.transform.position, Quaternion.identity);
        tempBullet.transform.localScale = new Vector3(.01f, .01f, .01f);
        tempBullet.SetActive(true);
        tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    void Start()
    {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
}
