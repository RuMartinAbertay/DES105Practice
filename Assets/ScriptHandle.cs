using UnityEngine;

public class ScriptHandle : MonoBehaviour
{
    float screenPointZ;
    Vector3 offset;

    private void OnMouseDown()
    {
        screenPointZ = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPointZ));
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPointZ)) + offset;
    }
}
