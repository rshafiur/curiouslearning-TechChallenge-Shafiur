using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

    [SerializeField]
    private Transform catPlace;

    private Vector2 initialPosition;
    private float deltaX, deltaY;

    public static bool locked;

    private float cameraOffset;
    private Vector3 offset;

    // Use this for initialization
    void Start () {

        initialPosition = transform.position;
        cameraOffset = -Camera.main.transform.position.z;
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            //moveAlowed = true;
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraOffset));
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraOffset);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - catPlace.position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - catPlace.position.y) <= 0.5f)
        {
            transform.position = new Vector2(catPlace.position.x, catPlace.position.y);
            locked = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}
