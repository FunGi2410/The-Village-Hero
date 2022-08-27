using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMission : MonoBehaviour
{
    public new string name;

    private void Start()
    {
        this.name = gameObject.name;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
