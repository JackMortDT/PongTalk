using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    private GameObject ball;


	void Start () {
        SpawnBall();
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void SpawnBall () {
        ball = GameObject.Instantiate((GameObject)Resources.Load("Prefabs/ball", typeof(GameObject)));
        ball.transform.localPosition = new Vector3(12, 0, -2);

    }

}
