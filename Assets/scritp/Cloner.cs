using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    // Start is called before the first frame update
  private void OnTriggerEnter(Collider other) {
      Instantiate(other.gameObject);
  }

}
