using UnityEngine;

public class ScriptRopeOld : MonoBehaviour
{
    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public int links;

    void Start()
    {
        GenerateRope();
    }

    void GenerateRope()
    {
        Rigidbody2D prevRB = hook;
        for (int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = prevRB;

            if (i < links - 1)
            {
                prevRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                //scriptPaintbrush.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }

        }
    }
}
