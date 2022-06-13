using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Camera currentCamera; //get the point we have clicked in world space
    public LayerMask layerMask; //detects which colliders we wish to be detected
    public float threshold = 0.5f; //helps detect misclicks

    private GameObject selectedObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }

        if (Input.GetMouseButtonUp(0))
        {
            HandleMovement();
        }
    }

    private void HandleSelection()
    {
        Vector3 mouseInput = currentCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseInput.z = 0f;
        Collider2D collider = Physics2D.OverlapPoint(mouseInput, layerMask);
        selectedObject = collider == null ? null : collider.gameObject;
    }

    private void HandleMovement()
    {
        if (selectedObject == null)
            return;

        Vector3 endPosition = currentCamera.ScreenToWorldPoint(Input.mousePosition);
        endPosition.z = 0f; //ensures correct position and locks z

        if (Vector2.Distance(endPosition, selectedObject.transform.position) > threshold) //checks for misclicks.
        {
            Vector2 direction = (endPosition - selectedObject.transform.position);
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                float sign = Mathf.Sign(direction.x);
                direction = Vector2.right * sign;
            }
            else
            {
                float sign = Mathf.Sign(direction.y);
                direction = Vector2.up * sign;
            }
            selectedObject.transform.position += (Vector3)direction;
        }
    }
}
