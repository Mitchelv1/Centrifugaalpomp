using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualScreenInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    Collider screenCollider;
    void Start()
    {
        screenCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == screenCollider)
                {

                }
            }
        }
    }
}
