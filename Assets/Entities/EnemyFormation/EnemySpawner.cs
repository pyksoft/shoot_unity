using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

  public GameObject enemyPrefab;

  // Use this for initialization
  void Start() {

    foreach (Transform child in transform) {
      GameObject enemy = Instantiate(enemyPrefab, new Vector3 (child.transform.transform.position.x, child.transform.transform.position.y, 0), Quaternion.identity) as GameObject;
      enemy.transform.parent = child;
    }

  }
	
  // Update is called once per frame
  void Update() {
	
  }
}
