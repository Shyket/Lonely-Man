using System;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon_select : MonoBehaviour
{
    public GameObject weapon;
    public Animator anim;
    private float speed;
    public CharacterController controller;

    private int fireHash;
    private int speedHash;
    private int isIdleHash;
   

    private void Start()
    {
        fireHash = Animator.StringToHash("fire");   
        speedHash = Animator.StringToHash("speed");
        isIdleHash = Animator.StringToHash("isIdle");
    }

    void Update()
    {
        calaulateSpeed();
        //Debug.Log(speed);
        if (weapon.activeInHierarchy)
        {
            anim.SetFloat(speedHash, speed);
            if (speed == 0f)
            {
                anim.SetBool(isIdleHash, true);
            }
            else
            {              
                anim.SetBool(isIdleHash, false);
            }
        }

        if (Input.GetButtonDown("weapon select"))
        {
            if (weapon.activeInHierarchy)
            {
 
                anim.SetBool(fireHash, false);
                
                weapon.SetActive(false);
            }
            else
            {
                weapon.SetActive(true);
            }

        }
    }

    private void calaulateSpeed()
    {
        
        speed = Math.Abs(new Vector3(controller.velocity.x,0, controller.velocity.z).magnitude);
        
       
    }
}
