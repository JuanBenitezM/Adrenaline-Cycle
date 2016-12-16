using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{

    public GameObject target;

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    AudioSource myAudiosource;

    [SerializeField]
    GameObject PlayerFPCamera;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //GameObject target;

        if( Input.GetMouseButtonUp( 0 ) )
        {
            Attack();
        }



    }

    private void Attack()
    {
        //myAnimator.SetTrigger("Shoot");
        //myAudiosource.Play();

        float distance = Vector3.Distance( target.transform.position, transform.position );

        if( distance < 5 )
        {
            Debug.Log( "Its happening" );
            Enemy enemy = target.GetComponent<Enemy>();
            if( enemy )
                enemy.Damage( 10, PlayerFPCamera.transform.parent );

        }

    }
}

