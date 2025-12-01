using UnityEngine;

public class ScriptHandle : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // ScriptHandle:
    // Allows the handle to be dragged around with the mouse.
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    float screenPointZ;
    Vector3 offset;

    private void OnMouseDown()
    {
        // Normalises the Z axis position of the target area
        screenPointZ = Camera.main.WorldToScreenPoint(transform.position).z;
        // Creates a vector for the offset between the mouse and the centre of the handle, in order to prevent the centre snapping directly onto the mouse when clicked
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPointZ));
    }

    private void OnMouseDrag()
    {
        // Sets the position of the handle to the offset position of the mouse
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPointZ)) + offset;
    }
}
