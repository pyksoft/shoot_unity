using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public float speed = 15.0f;
  public float padding = 0.1f;

  private float xmin;
  private float xmax;
  private float ymin;
  private float ymax;



  void Start() {

    float distanceZ = transform.position.z - Camera.main.transform.position.z;

    Vector3 leftDownCorner = Camera.main.ViewportToWorldPoint(new Vector3 (0, 0, distanceZ));
    Vector3 rightUpCorner = Camera.main.ViewportToWorldPoint(new Vector3 (1, 1, distanceZ));
   
    xmin = leftDownCorner.x + padding;
    xmax = rightUpCorner.x - padding;
    ymin = leftDownCorner.y + padding;
    ymax = rightUpCorner.y - padding;

  }

  // Update is called once per frame
  void Update() {
    MovePlayer();
  }

  void MovePlayer() {
 
    if (Input.GetKey(KeyCode.UpArrow)) {

      // two methods possible
      // this.transform.position += new Vector3 (0, speed * Time.deltaTime, 0);
      this.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    if (Input.GetKey(KeyCode.DownArrow)) {
      this.transform.position += Vector3.down * speed * Time.deltaTime;

    }

    if (Input.GetKey(KeyCode.LeftArrow)) {
      this.transform.position += Vector3.left * speed * Time.deltaTime;
    }

    if (Input.GetKey(KeyCode.RightArrow)) {
      this.transform.position += Vector3.right * speed * Time.deltaTime;
    }

    // Restrict the position in game
    float newX = Mathf.Clamp(this.transform.position.x, xmin, xmax);
    float newY = Mathf.Clamp(this.transform.position.y, ymin, ymax);

    this.transform.position = new Vector3 (newX, newY, this.transform.position.z);

  }
}
