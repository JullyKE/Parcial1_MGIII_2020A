using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSEUShoot : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform[] firePoint;
	public float fireDelay = 0.25f;
	
	float coolTime = 0;
	
    void Update()
    {
	    coolTime = fireDelay;
	    if ((Input.GetMouseButtonDown(0)) && coolTime <= 0)
	    {
	    	coolTime = fireDelay;
	    	foreach(Transform fire in firePoint)
	    	{
		     	Instantiate(bulletPrefab,fire.position,Quaternion.identity);
	    	}
	    }
    }
}
