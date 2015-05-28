using UnityEngine;
using System.Collections;

public class Ball : AwesomeScript
{
	public float speed;
	public GameObject leftRacket;
	public GameObject rightRacket;
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
		self.SetVelocity (speed, speed / 3f );
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		if(!self.GetComponent<Renderer>().isVisible)
		{
			self.SetPosition (0,0);
			self.SetVelocity (speed, speed / 3f);
		}
	}
	
	void FixedUpdate()
	{
	
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{
		float newVelocityX = 0f;
		float newVelocityY = 0f;
		
		if(other.gameObject == leftRacket)
		{
			newVelocityX = speed;
			//newVelocityY = self.GetPositionY () - other.gameObject.GetPositionY
		}
		if(other.gameObject == rightRacket)
		{
			self.SetVelocityX( -speed);
		}
	}
}
