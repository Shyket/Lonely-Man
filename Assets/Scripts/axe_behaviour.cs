using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe_behaviour : MonoBehaviour
{
    public Animator anim;
    public GameObject weapon;
    public float range;
    RaycastHit hit;
    Transform hitObject;
    public float damagePerAttack;
    private int fireHash;

    // Start is called before the first frame update
    void Start()
    {
        fireHash = Animator.StringToHash("fire");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
            if (weapon.activeInHierarchy)
            {
                anim.SetBool(fireHash, true);
            }
               
            if (Physics.Raycast(weapon.transform.position,
                                weapon.transform.TransformDirection(Vector3.forward),
                                out hit,
                                range))
            {

                if (hit.transform.tag.Equals("enemy"))
                {
                    hitObject = hit.transform;
                    Invoke("reduceEnemyHealth", 1f);
                }                   
            }
        }
    }

    public void reduceEnemyHealth()
    {
        if(hitObject != null)
        {
            hitObject.SendMessage("reduceHealth", damagePerAttack, SendMessageOptions.DontRequireReceiver);

        }
    }

}
