using UnityEngine;

public class ScriptPaintbrush : MonoBehaviour
{
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
        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
        currentLineRenderer.SetPosition(0, transform.position);
        currentLineRenderer.SetPosition(1, transform.position);
    }
    private void Update()
    {
        if ((Vector2)transform.position != lastPos)
        {
            AddPoint(transform.position);
            lastPos = transform.position;
        }
    }
    void AddPoint(Vector2 pointPos)
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }

    //void Draw()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        CreateBrush();
    //    }
    //    if (Input.GetKey(KeyCode.Mouse0))
    //    {
    //        if ((Vector2)transform.position != lastPos)
    //        {
    //            AddPoint(transform.position);
    //            lastPos = transform.position;
    //        }
    //    }
    //    else
    //    {
    //        currentLineRenderer = null;
    //    }
    //}




}
