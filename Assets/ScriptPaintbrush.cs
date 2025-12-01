using UnityEngine;

public class ScriptPaintbrush : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // ScriptPaintbrush:
    // Creates a line across the path made by the paintbrush.
    // = - = - = - = - = - = - = - = - = - = - = - = - = - = -

    public Camera mainCamera;
    public GameObject brush;

    LineRenderer currentLineRenderer;
    Vector2 lastPos;

    private void Start()
    {
        CreateBrush();
    }

    void CreateBrush()
    {
        // Creates a new brushstroke instance, setting the first two points in the line
        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
        currentLineRenderer.SetPosition(0, transform.position);
        currentLineRenderer.SetPosition(1, transform.position);
    }

    private void Update()
    {
        // Checks to see if the brush has moved from the last recorded position
        if ((Vector2)transform.position != lastPos)
        {
            // Adds a new point to the line, equal to the current position
            AddPoint(transform.position);
            // Sets the last recorded position to the current position
            lastPos = transform.position;
        }
    }

    void AddPoint(Vector2 pointPos)
    {
        // Increases the line's total number of points by 1, and sets the position index marker to the highest point
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }
}
