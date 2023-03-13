using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auravision
{
	public class MovementController : MonoBehaviour
	{
		[SerializeField] float movementSpeed;
		Vector2 movement = Vector2.zero;
		Rigidbody2D playerRB;

        private void Awake()
        {
            playerRB= GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
           
        }
        private void FixedUpdate()
        {
            //get inputs
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            movement.Normalize();

            playerRB.velocity = movement*movementSpeed;
        }
    }

}