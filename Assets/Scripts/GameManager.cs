using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawn()
    {
        Vector3 ballPrefabPosition = new Vector3(Random.Range(-0.495f, 0.569f), 1.139f, Random.Range(-0.495f, 0.569f));
        Instantiate(ballPrefab, ballPrefabPosition, Quaternion.identity);
    }
}
