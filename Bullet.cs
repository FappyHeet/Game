using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public Rigidbody2D rb;
	public GameObject ImpactEffect;


	//public Freeze fr;

	#region Variables
	#endregion

	#region Unity Methods
	
	
	void Start()
    {
		rb.velocity = transform.right * speed;
    }

	private void OnTriggerEnter2D(Collider2D onCollision)
	{

		//Debug.Log(hitInfo.name);
		Instantiate(ImpactEffect, transform.position, transform.rotation);		
		Destroy(gameObject);

		/*
		if (collision.collider.name == "")//in "" put name of bullet
		{
			if (collision.otherCollider.name == "")//in "" put name of froge
			{
				rb.constraints = RigidbodyConstraints2D.FreezePosition;
			}
		}
		*/
	}
	public void unfreezefroge()//this add to a button
	{
		rb.constraints = RigidbodyConstraints2D.None;

	}

	

	void Update()
    {
        
    }
    
    #endregion
}
