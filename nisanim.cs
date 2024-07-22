using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Perform the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // Log the name of the object hit by the ray
                Debug.Log("Hit " + hit.collider.gameObject.name);

                // Optionally, you can perform additional actions with the hit object
                // For example, changing its color:
                Renderer renderer = hit.collider.gameObject.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material.color = Color.red;
                }
            }
        }
    }
}
