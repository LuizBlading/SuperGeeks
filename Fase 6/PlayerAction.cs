using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject bullet; 

    public float speed = 10f;

    private GameObject createdBullet;
    private Rigidbody bullet_rig;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        // Salva a camera do player e salva na variavel cam
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            // Guarda a instancia(Spawn) da bullet na variavel createdBullet
            createdBullet = Instantiate(bullet);
            // A posição da bala, é a mesma da do player.
            createdBullet.transform.position = transform.position;

            // Salva o rigidbody da bullet na variavel bullet_rig
            bullet_rig = createdBullet.GetComponent<Rigidbody>();

            // Atribui velocidade para a bullet, e faz sair da mesma direção
            // que a camera esta olhando
            bullet_rig.velocity = cam.transform.rotation * Vector3.forward * speed;
        }
    }
}
