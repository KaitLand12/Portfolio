using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int score = 0;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fish"))
        {
            Destroy(collision.gameObject);
            score++;
        }
    }
}
