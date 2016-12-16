using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GunControl : MonoBehaviour 
{
    //public AttackArea AttackArea;

	[SerializeField]
	Animator myAnimator;

	[SerializeField]
	AudioSource myAudiosource;

	[SerializeField]
	GameObject PlayerFPCamera;

	public GameObject target;

    void Update()
    {
            if (CrossPlatformInputManager.GetButtonDown("Fire1"))
            {
                Debug.Log("Damage");
                Swing();
            }
    }


	public void Swing()
	{
        if (CrossPlatformInputManager.GetButtonDown ("Fire1")) 
        {
        myAnimator.SetTrigger("Shoot");
        //myAudiosource.Play();

        RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 2f);
            GameObject target = hit.collider.transform.gameObject;
            Enemy enemy = target.GetComponent<Enemy>();
            if (enemy)
                enemy.Damage(20, PlayerFPCamera.transform.parent);
            Debug.DrawLine(transform.position, hit.point, Color.cyan);
        }
    }
		
		
	
}


