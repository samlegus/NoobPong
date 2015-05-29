using UnityEngine;
using System.Collections;

public class Racket : AwesomeScript
{
	public string inputAxisName;
	public float speed;
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
	
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		
	}
	
	void FixedUpdate()
	{
		float verticalMovement = Input.GetAxisRaw (inputAxisName);
		self.SetVelocityY(verticalMovement * speed);
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{
		
	}
}
