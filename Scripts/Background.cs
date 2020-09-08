using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public GameObject[] cloud1Array = new GameObject[2];
    public GameObject[] cloud2Array = new GameObject[2];
    public GameObject[] cloud3Array = new GameObject[2];
    bool createdCloud1 = false;
    bool createdCloud2 = false;
    bool createdCloud3 = false;
 
    void Start()
    {
        cloud1Array[0] = Instantiate(cloud1, new Vector3(1486f, 679, 91), Quaternion.identity);
        cloud2Array[0] = Instantiate(cloud2, new Vector3(888f, 715, 91), Quaternion.identity);
        cloud3Array[0] = Instantiate(cloud3, new Vector3(346f, 862, 91), Quaternion.identity);
    }


    void Update()
    {
        //cloud1
        cloud1Array[0].transform.position += new Vector3(10* Time.deltaTime, 0, 0);
        if(cloud1Array[1] != null)
        {
            cloud1Array[1].transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
        }
        //cloud2
        cloud2Array[0].transform.position += new Vector3(8 * Time.deltaTime, 0, 0);
        if (cloud2Array[1] != null)
        {
            cloud2Array[1].transform.position += new Vector3(8 * Time.deltaTime, 0, 0);
        }
        //cloud3
        cloud3Array[0].transform.position += new Vector3(12 * Time.deltaTime, 0, 0);
        if (cloud3Array[1] != null)
        {
            cloud3Array[1].transform.position += new Vector3(12* Time.deltaTime, 0, 0);
        }
        //cloud1
        if (cloud1Array[0].transform.position.x >= 1561f && !createdCloud1)
        {
            cloud1Array[1] = Instantiate(cloud1, new Vector3(-320f, 679, 91), Quaternion.identity);
            createdCloud1 = true;
        }
        if (cloud1Array[0].transform.position.x >= 2200f)
        {   
            Destroy(cloud1Array[0]);
            cloud1Array[0] = cloud1Array[1];
            cloud1Array[1] = null;
            createdCloud1 = false;
        }
        //cloud2
        if (cloud2Array[0].transform.position.x >= 1728f && !createdCloud2)
        {
            cloud2Array[1] = Instantiate(cloud2, new Vector3(-53f, 715, 91), Quaternion.identity);
            createdCloud2 = true;
        }
        if (cloud2Array[0].transform.position.x >= 1978f)
        {
            Destroy(cloud2Array[0]);
            cloud2Array[0] = cloud2Array[1];
            cloud2Array[1] = null;
            createdCloud2 = false;
        }
        //cloud3
        if (cloud3Array[0].transform.position.x >= 1661f && !createdCloud3)
        {
            cloud3Array[1] = Instantiate(cloud3, new Vector3(-121f, 862, 91), Quaternion.identity);
            createdCloud3 = true;
        }
        if (cloud3Array[0].transform.position.x >= 2130f)
        {
            Destroy(cloud3Array[0]);
            cloud3Array[0] = cloud3Array[1];
            cloud3Array[1] = null;
            createdCloud3 = false;
        }
    }
}