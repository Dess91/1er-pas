using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kami : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
   Destroy(other.gameObject);
   Destroy(gameObject);
  }
}
