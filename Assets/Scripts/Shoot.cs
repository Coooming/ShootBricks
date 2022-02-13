using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 20;
	
	void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 判断是否按下了鼠标，0为鼠标左键
        {
            GameObject bulletObject = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody bulletRigidbody = bulletObject.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * speed;
        }
    }
}
