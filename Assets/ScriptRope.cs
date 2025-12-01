using UnityEngine;

public class ScriptRope : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - =
    // ScriptRope:
    // Handles the creation of the rope.
    // = - = - = - = - = - = - = - = - =

    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public GameObject brush;
    public int links;
    public ScriptRopeEnd scriptRopeEnd;

    void Start()
    {
        GenerateRope();
    }


    void GenerateRope()
    {
        // Sets the handle's hook object to be attached to the first link in the chain
        Rigidbody2D prevRB = hook;
        // Runs as many times as the pre-specified number of links in the chain
        for (int i = 0; i < links; i++)
        {
            // Creates a new link object from the prefab
            GameObject link = Instantiate(linkPrefab, transform);
            // Finds the link's HingeJoint 2D and connects it to the previous link
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = prevRB;

            // If the current link is not the last:
            if (i < links - 1)
            {
                // Prepares for the next loop by listing the current link as the previous one
                prevRB = link.GetComponent<Rigidbody2D>();
            }
            // If the current link is the last
            else
            {
                // Turns the link invisible - This final link will be overlaid on top of the paintbrush to
                // prevent movement wonkiness, similar to the handle's hook
                link.GetComponent<Renderer>().enabled = false;
                // Calls for the paintbrush to finalise the connection
                scriptRopeEnd.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
}
