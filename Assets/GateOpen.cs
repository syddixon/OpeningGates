using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        FindAndSub(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("OpenGate");
    }
    private void OnTriggerExit(Collider other)
    {
        animator.Play("CloseGate");
    }

    public void OnPowerUp()
    {
        animator.Play("OpenGate");
    }

    public void FindAndSub()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Coin");
        if (obj != null)
        {
            obj.GetComponent<Coin>().PowerUp.AddListener(OnPowerUp);
        }
    }

}
