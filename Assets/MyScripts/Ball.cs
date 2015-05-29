using UnityEngine;
using System.Collections;

public class Ball : AwesomeScript
{
	public float speedX;
	public float speedY;

	public GameObject leftRacket;
	public GameObject rightRacket;
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
		self.SetVelocity (speedX , 0f );
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		if(self.IsVisible() == false)
		{
			self.SetPosition (0f,0f);
			self.SetVelocity (speedX, 0f);
		}
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject == leftRacket)
		{
			float newVelocityX = 0f;
			float newVelocityY = 0f;
			float racketHeight = other.gameObject.GetColliderHeight();
			
			newVelocityX = speedX;
			newVelocityY = (self.GetPositionY () - other.gameObject.GetPositionY() / racketHeight) * speedY;

			self.SetVelocity (newVelocityX, newVelocityY);
		}
		if(other.gameObject == rightRacket)
		{
			float newVelocityX = 0f;
			float newVelocityY = 0f;
			float racketHeight = other.gameObject.GetColliderHeight();
			
			newVelocityX = speedX * -1f;
			newVelocityY = (self.GetPositionY () - other.gameObject.GetPositionY() / racketHeight) * speedY;

			self.SetVelocity (newVelocityX, newVelocityY);
		}
	}
	
	void OnGUI()
	{
		
	}
}
