using UnityEngine;

public class ScriptRopeEnd : MonoBehaviour
{
    // = - = - = - = - = - = - = - = - = - = - = - = - = - =
    // ScriptRopeEnd:
    // Connects the paintbrush to the last link of the rope.
    // = - = - = - = - = - = - = - = - = - = - = - = - = - =

    public float distanceFromLastRope;

    // Called by the GenerateRope function
    public void ConnectRopeEnd (Rigidbody2D lastRope)
    {
        // Creates a new HingeJoint2D component for the paintbrush
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        // Resets the position of the hinge joint anchor
        joint.autoConfigureConnectedAnchor = false;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = Vector2.zero;
        // Connects the joint to the last link
        joint.connectedBody = lastRope;
    }
}
