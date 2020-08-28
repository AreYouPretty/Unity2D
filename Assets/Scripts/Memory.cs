using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private Sprite image;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = image;
    }
    public void OnMouseDown()
    {
        if (cardBack.activeSelf)
        {
            cardBack.SetActive(false);
        }
    }
}
