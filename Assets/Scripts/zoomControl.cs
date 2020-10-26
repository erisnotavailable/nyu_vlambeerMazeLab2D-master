using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomControl : MonoBehaviour
{
    float xAxis, yAxis;
    public float zoomSpeed = 0.3f;
    public Camera mainCam;

    // Update is called once per frame
    void Update()
    {
        if (FloorMaker.makerList.Count > 0) {
            // relocate camera to the center of all FloorMakers
            xAxis = 0; yAxis = 0;
            for(int i = 0; i < FloorMaker.makerList.Count; ++i) {
                xAxis += FloorMaker.makerList[i].position.x;
                yAxis += FloorMaker.makerList[i].position.y;
            }
            xAxis = xAxis/FloorMaker.makerList.Count;
            yAxis = yAxis/FloorMaker.makerList.Count;

            mainCam.transform.position = new Vector3(xAxis, yAxis, -10);

            // zoom out until every FloorMaker is visible
            if(mainCam.orthographicSize < 25) {
                mainCam.orthographicSize += zoomSpeed;
            }
        } else {
            Debug.Log("makerList is null");
        }
    }
}
