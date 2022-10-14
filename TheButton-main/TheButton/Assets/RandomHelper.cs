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

    // When player hit the diamond, the diamond becomes
    // random CookingHelper and diamond disappears;
    public void GetHelper()
    {
        Vector3 position = transform.position;
        Instantiate(helper[Random.Range(0, helper.Length)],position, Quaternion.identity);
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
