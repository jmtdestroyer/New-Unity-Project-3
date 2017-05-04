using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //hämtar bullet prefab
    public GameObject bullet_prefab;
    public float BulletImpulse;
    //variabel för ljudet när kulan skjuts
    public AudioClip ShootSound;

    private AudioSource source;
    //variabler för hur högt och lågt ljudet ska låta
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start()
    {

    }


    void Awake()
    {
        //
        source = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            Camera cam = Camera.main;
            GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position, cam.transform.rotation);
            thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * BulletImpulse, ForceMode.Impulse);

            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(ShootSound, vol);
        }
    }
}
