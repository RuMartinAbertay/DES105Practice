using UnityEngine;

public class ScriptRopeEnd : MonoBehaviour
{
    public float distanceFromLastRope;

    public void ConnectRopeEnd (Rigidbody2D lastRope)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastRope;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceFromLastRope);
    }
}
