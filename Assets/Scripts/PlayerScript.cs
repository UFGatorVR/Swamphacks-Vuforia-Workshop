using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Slider slider;
    private float health = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet1")
        {
            Destroy(collision.gameObject);
            health += .1f;
            slider.value = health;
            if (health >= 1) SceneManager.LoadScene(0);
        }
    }

}
