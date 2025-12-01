using UnityEngine;

public class ScriptPaintbrushPosition : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // ScriptPaintbrushPosition:
    // Handles the maximum distance from the handle to the paintbrush.
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    public GameObject handle;
    [SerializeField] float maxLength;
    Vector3 lengthBetween;
    float magnitude;
    Vector3 handlePosition;

    void Update()
    {
        handlePosition = handle.transform.position;
        lengthBetween = gameObject.transform.position - handlePosition;
        magnitude = Mathf.Abs(lengthBetween.magnitude);
        if (magnitude > maxLength)
        {
            gameObject.transform.position = handlePosition + (lengthBetween.normalized * maxLength);
        }
    }
}
