using UnityEngine;

public class Weapon : MonoBehaviour
{

	#region Variables
	public Transform firePoint;	
	public GameObject bulletPrefab;



	#endregion

	#region Unity Methods

	void Start()
    {
        
    }


    void Update()
    {
		if(Input.GetButtonDown("Fire1_P1"))
		{
			
			Shoot();
		}
    }
    
	void Shoot()
	{
		//shooting logic
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

	}
    #endregion
}


/*
  public Rigidbody rb;
public void freeze()
{
if(bullethitsenemy)
{
rb.constraints = RigidbodyConstraints.FreezeAll;
}
}
*/