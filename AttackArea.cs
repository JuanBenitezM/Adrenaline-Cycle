using UnityEngine;
using System.Collections;

public class AttackArea : MonoBehaviour {


    public GunControl _GunControl;

    public bool enemyHere = false;

    public GameObject target;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }



    //void FindTarget() {

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy")) {
            Debug.Log("Inside");
            enemyHere = true;
            _GunControl.Swing();
        }

    }

}

