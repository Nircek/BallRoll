using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalController : MonoBehaviour
{
    int crystalNumber = 0;
    public GameObject particles;

    void Start()
    {
        crystalNumber = Component.FindObjectsOfType<CrystalController>().Length;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "sphere_player") {
            int remainingNumber = Component.FindObjectsOfType<CrystalController>().Length - 1;
            int collectedNumber = crystalNumber - remainingNumber;
            Debug.Log(collectedNumber.ToString() + "/" + crystalNumber.ToString());
            Instantiate(particles, transform.position, Quaternion.identity);
            Object.Destroy(gameObject, 0.1f);
        }
    }
}
