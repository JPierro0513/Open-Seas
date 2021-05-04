using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity.Example 
{
    public class PlayerMovement : MonoBehaviour
    {

        public UnityEngine.CharacterController controller;
        public GameObject player;
        //public GameObject popupUI;

        public float speed = 12f;
        public float gravity = -9.8f;
        public float interactionRadius = 4.0f;

        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;

        Vector3 velocity;
        bool isGrounded;

        // Update is called once per frame
        void Update()
        {
            
            if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == true)
            {
                Cursor.lockState = CursorLockMode.None; 
                return;
            }

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0) 
                velocity.y = -2f;

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);

            if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
                CheckForNearbyNPC();
        }

        public void CheckForNearbyNPC ()
        {
            var allParticipants = new List<NPC> (FindObjectsOfType<NPC> ());
            var target = allParticipants.Find (delegate (NPC p) {
                return string.IsNullOrEmpty (p.talkToNode) == false && (p.transform.position - this.transform.position).magnitude <= interactionRadius;
            });
            if (target != null)
                FindObjectOfType<DialogueRunner>().StartDialogue (target.talkToNode);
        }
    }
}
