using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Runlight : MonoBehaviour
{
    public GameObject[] pathGameObject;

    private Material mat;
    private float timer = 0;
    private int count;
    // Use this for initialization
    private void Start()
    {
        //mat = pathGameObject[count].GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    private void Update()
    {
        RunLightEffect();
    }

    private void RunLightEffect()

    {
        if (timer > 0.2f)
        {
            timer = 0;
            if (count < 0)
            {
                count = pathGameObject.Count() - 1;
            }
            foreach (GameObject go in pathGameObject)
            {
                go.gameObject.GetComponent<MeshRenderer>().material= Resources.Load<Material>("Materials/white");
                go.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                //go.SetActive(true);
            }
            pathGameObject[count].GetComponent<MeshRenderer>().material.color = Color.red;
            count--;
            //go.SetActive(true);
        }
        timer += Time.deltaTime;
    }
}
