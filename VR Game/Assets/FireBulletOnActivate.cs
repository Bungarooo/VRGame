using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    [SerializeField] float fireSpeed = 20f;

    [SerializeField] float timeTilDestroyed = 5f;

    [Header("References")]
    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnPoint;

    void Start()
    {
        var grabbable = this.GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, timeTilDestroyed);
    }
}
