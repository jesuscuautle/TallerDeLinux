using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeN1 : MonoBehaviour
{
    public float vel = 1.0f;
    private Animator anim;
    public float x, y;
    public GameObject TextoFlotante;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vx", x);
        anim.SetFloat("vy", y);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            MostrarTextoFlotante();
        }
    }

    public void MostrarTextoFlotante()
    {
        GameObject texto = Instantiate(TextoFlotante);
        texto.transform.position = new Vector3(this.gameObject.transform.position.x+8,
            this.gameObject.transform.position.y + 2,
            this.gameObject.transform.position.z - 10);
        texto.transform.Rotate(0.0f, 160.0f, 0.0f, Space.Self);
    }
}
