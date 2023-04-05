using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LevelCamera : MonoBehaviour
{

    public Transform StartPoint;

    public Transform EndPoint;
    // Start is called before the first frame update
    void Start()
    {
        var level = FindObjectOfType<Level>();
        
        StartPoint = level.StartPoint;
        EndPoint = level.EndPoint;
        
        this.transform.position = StartPoint.transform.position;
        this.transform.DOMove(EndPoint.transform.position, 65, false);
    }

    // Update is called once per frame
    void Update()
    {
        var playerPosition = FindObjectOfType<Player>().transform.position;

        Debug.Log(GetComponent<Camera>().WorldToViewportPoint(playerPosition));
    }
}
