using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Difference : MonoBehaviour
{
    public static event Action DifferenceClicked = delegate { };

    [SerializeField]
    private GameObject pair;

    private SpriteRenderer spRend;

    // Start is called before the first frame update
    void Start()
    {
        spRend = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (spRend.enabled)
        {
            pair.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            pair.GetComponent<BoxCollider2D>().enabled = false;
            DifferenceClicked();
        }
        else
        {
            spRend.enabled = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            pair.GetComponent<BoxCollider2D>().enabled = false;
            DifferenceClicked();
        }
    }
}
