using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GC
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler InputHandler;
        Animator anim;
        void Start()
        {
            InputHandler = GetComponent<InputHandler>();
            anim = GetComponentInChildren<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            InputHandler.isInteracting = anim.GetBool("isInteracting");
            InputHandler.rollFlag = false;
            InputHandler.sprintFlag = false;
        }
    }

}
