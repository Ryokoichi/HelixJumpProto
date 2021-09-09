using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public string material;
    public GameObject splashPrefab;


    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -.23f, 0f) , transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);


        material = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(material);

        if (material == "SafeColor (Instance)")
        {

        }
        else if (material == "UnsafeColor (Instance)")
        {

        }
        else if (material == "FinalSuccess (Instance)")
        {

        }


    }

}
