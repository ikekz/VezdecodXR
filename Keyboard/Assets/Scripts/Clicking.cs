using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour
{
    bool isClicked = false;
    Vector3 offset = new Vector3(0, 0.005f, 0);
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        int value = Random.Range(0, 50000);
        if (!isClicked && value <= 2)
        {
            Click();
        }
        else if (isClicked && value <= 2)
        {
            UnClick();
        }
    }

    void Click()
    {
        gameObject.transform.position -= offset;
        audioSource.Play();
        isClicked = true;
    }

    void UnClick()
    {
        gameObject.transform.position += offset;
        isClicked = false;
    }
}
