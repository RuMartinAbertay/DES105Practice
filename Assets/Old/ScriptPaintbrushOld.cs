using UnityEngine;

public class ScriptPaintbrushOld : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject brush;

    LineRenderer currentLineRenderer;
    Vector2 lastPos;

    public float distanceFromChainEnd;
    public GameObject hook;

    private void Start()
    {
        hook.GetComponent<HingeJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Draw();
    }

    void Draw()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if ((Vector2)transform.position != lastPos)
            {
                AddPoint(transform.position);
                lastPos = transform.position;
            }
        }
        else
        {
            currentLineRenderer = null;
        }
    }

    void CreateBrush()
    {
        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
        currentLineRenderer.SetPosition(0, transform.position);
        currentLineRenderer.SetPosition(1, transform.position);
    }

    void AddPoint(Vector2 pointPos)
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }

    public void ConnectRopeEnd(Rigidbody2D endRB)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRB;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0, distanceFromChainEnd);
    }
}
