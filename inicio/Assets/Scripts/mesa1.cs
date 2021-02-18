using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesa1 : MonoBehaviour
{
    public GameObject TextoFlotante;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        texto.transform.position = new Vector3(this.gameObject.transform.position.x-4,
            this.gameObject.transform.position.y+2,
            this.gameObject.transform.position.z+10);
    }
}
