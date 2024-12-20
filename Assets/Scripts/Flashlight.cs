using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightActive = false;
    public AudioSource click;
    // Start is called before the first frame update
    void Start()
    {
        FlashlightLight.gameObject.SetActive(false);
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(FlashlightActive == false)
            {
                click.Play();
                FlashlightLight.gameObject.SetActive(true);
                FlashlightActive = true;
            }
            else
            {
                click.Play();
                FlashlightLight.gameObject.SetActive(false);
                FlashlightActive = false;
            }
        }
    }
}
