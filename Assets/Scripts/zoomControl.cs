using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomControl : MonoBehaviour
{
    float xAxis, yAxis;
    public float zoomSpeed = 0.3f;
    public Camera mainCam;
    List<Transform> mklist;

    void Awake() {
        Debug.Log("It's being loaded");
        mklist = FloorMaker.makerList;
    }
    // Update is called once per frame
    void Update()
    {
        if (mklist[0] != null) {
            // relocate camera to the center of all FloorMakers
            xAxis = 0; yAxis = 0;
            for(int i = 0; i < mklist.Count; ++i) {
                xAxis += mklist[i].position.x;
                yAxis += mklist[i].position.y;
            }
            xAxis = xAxis/mklist.Count;
            yAxis = yAxis/mklist.Count;

            mainCam.transform.position = new Vector3(xAxis, yAxis, -10);

            // zoom out until every FloorMaker is visible
            if(mainCam.orthographicSize < 25) {
                mainCam.orthographicSize += zoomSpeed;
            }
        }
    }
}
