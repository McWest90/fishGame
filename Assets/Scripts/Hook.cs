using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Diagnostics;

public class Hook : MonoBehaviour
{
    public Transform hookedTransfrom;


    private Camera mainCamera;
    private Collider2D coll;


    private int length;
    private int strength;
    private int fishCount;


    private bool canMove = true;

    private Tweener cameraTween;

    void Awake() {
        mainCamera = Camera.main;
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove && Input.GetMouseButton(0))
        {
            Vector3 vector = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3 position = transform.position;
            position.x = vector.x;
            transform.position = position;
        }
    }
}
