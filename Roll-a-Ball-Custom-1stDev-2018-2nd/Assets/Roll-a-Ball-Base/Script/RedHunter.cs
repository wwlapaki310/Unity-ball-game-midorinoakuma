using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHunter : MonoBehaviour {

    [SerializeField] private float speed = 10.0f;
    private GameObject playerObject = null;
    private GameController gameController = null;
	
	void Update () {

        if(playerObject == null)
        {
            playerObject = GameObject.Find("Player");
        }

        if(gameController == null)
        {
            gameController = GameObject.Find("GameController").GetComponent<GameController>();
        }

        if (!gameController.isStarted) return;

        var vec = playerObject.transform.position - gameObject.transform.position;
        vec.Normalize();
        gameObject.transform.position += vec * speed * Time.deltaTime;
    }
}
