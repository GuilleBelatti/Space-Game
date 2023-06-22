using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public float life;
    public float damageTaken;
    public int powerCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == (10))
        {
            life--;
            damageTaken++;
        }
    }

    private void Update()
    {
        if(life <= 0)
            SceneManager.LoadScene("Menu");
    }
}
