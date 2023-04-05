using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Level : MonoBehaviour
{

    public Transform StartPoint;

    public Transform EndPoint;

    public List<LevelRegion> AvailableRegions;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Build();
        StartPoint = GameObject.FindWithTag("StartPoint").transform;
        EndPoint = GameObject.FindWithTag("EndPoint").transform;
    }

    // Update is called once per frame
    void Build()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(AvailableRegions[Random.Range(0, AvailableRegions.Count)], new Vector3(i * 50, 0, 0),
                Quaternion.identity, transform);
        }
    }
}
