using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragRings : MonoBehaviour {

    public static event Action PuzzleDone = delegate { };

    [SerializeField]
    private Transform standPosition;

    private Vector2 initialPosition;
    private Renderer rend;
    private float deltaX, deltaY;
    private bool moveAlowed;
    private bool locked;

    private float cameraOffset;
    private Vector3 offset;

    RingStackController rc;

    // Use this for initialization
    void Start () {
        cameraOffset = -Camera.main.transform.position.z;
        ResetObject();
        rc = GameObject.Find("RingStackGameController").GetComponent<RingStackController>() as RingStackController;
	}

    public void ResetObject()
    {
        locked = false;
        initialPosition = transform.position;
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            moveAlowed = true;
            rend.sortingOrder = 3;
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraOffset));
        }
    }

    private void OnMouseDrag()
    {
        if (moveAlowed && !locked)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraOffset);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    private void OnMouseUp()
    {
        moveAlowed = false;
        rend.sortingOrder = 2;

        if (Mathf.Abs(transform.position.x - standPosition.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - standPosition.position.y) <= 5f)
        {
            switch (RingStackController.slotsOccupied)
            {
                case 0:
                    transform.position = new Vector2(standPosition.position.x, rc.finalPositions[0]);
                    RingStackController.slotsOccupied = 1;
                    break;
                case 1:
                    transform.position = new Vector2(standPosition.position.x, rc.finalPositions[1]);
                    RingStackController.slotsOccupied = 2;
                    break;
                case 2:
                    transform.position = new Vector2(standPosition.position.x, rc.finalPositions[2]);
                    RingStackController.slotsOccupied = 3;
                    break;
                case 3:
                    transform.position = new Vector2(standPosition.position.x, rc.finalPositions[3]);
                    PuzzleDone();
                    break;
                default:
                    break;
            }

            locked = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
   
}
