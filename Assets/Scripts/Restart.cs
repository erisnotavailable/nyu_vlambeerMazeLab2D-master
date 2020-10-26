using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        //Press R to restart
		if (Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("Restart.");
			FloorMaker.grandTotal = 0;
            FloorMaker.makerList.Clear();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
    }
}
