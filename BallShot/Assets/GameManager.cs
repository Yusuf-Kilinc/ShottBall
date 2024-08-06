using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Toplar;
    public GameObject FirePoint;
    public float BallForce;
    int ActiveBallIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Toplar[ActiveBallIndex].transform.SetPositionAndRotation(FirePoint.transform.position, FirePoint.transform.rotation);
            Toplar[ActiveBallIndex].SetActive(true);


            Toplar[ActiveBallIndex].GetComponent<Rigidbody>().AddForce(Toplar[ActiveBallIndex].transform.TransformDirection(90, 90, 0) * BallForce, ForceMode.Force);
            

            if (Toplar.Length - 1 == ActiveBallIndex)
                ActiveBallIndex = 0;
            else
                ActiveBallIndex++;


        }
    }
}
