using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHelper : MonoBehaviour
{
    public GameObject[] helper;
    public GameObject diamond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GetHelper()
    {
        Vector3 pos = transform.position;
        Instantiate(helper[Random.Range(0, helper.Length)], pos, Quaternion.identity);
        Destroy(diamond);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("helper"))
        {
            GetComponent<RandomHelper>().GetHelper();
        }
    }
}
