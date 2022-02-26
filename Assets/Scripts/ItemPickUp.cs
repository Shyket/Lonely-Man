using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Transform targetPosition;
    public Rigidbody rb;
    public CapsuleCollider capsuleCollider;
    

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        rb.useGravity = false;
        capsuleCollider.enabled = false;
        this.transform.position = targetPosition.position;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
       
    }

    private void OnMouseUp()
    {
        rb.useGravity = true;
        capsuleCollider.enabled = true;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = null;
    }


}
