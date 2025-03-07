using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float Speed = 1;
    [SerializeField] GameObject Coin;
    [SerializeField] GameObject GateWallParent;
    bool coinInstantiated = false; 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float z = Speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x * Vector3.right + z * Vector3.forward);

        if (Input.GetKeyDown("space") && !coinInstantiated)
        {
           
            InstantiateCoin();
        }
    }

    public void InstantiateCoin()
    {
        GameObject coin = Instantiate(Coin);
        coinInstantiated = true;

        //GameObject obj = GameObject.FindGameObjectWithTag("Gate");
        //if (obj != null)
        //{
        //    obj.GetComponent<GateWallParent>().PowerUp.AddListener(OnPowerUp);
        //}

    }
}
