using System;
using UnityEngine;
using UnityEngine.UIElements;

public class teleport : MonoBehaviour
{
    public Transform trans;
    public Transform player;
    
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "teleport")
        {
            CharacterController cc = player.GetComponent<CharacterController>();
            cc.enabled = false;
            this.transform.position = trans.position;
            cc.enabled = true;
        }
        
    }
}
