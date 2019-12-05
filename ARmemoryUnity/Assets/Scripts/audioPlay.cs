using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
        // Start is called before the first frame update

    public GameObject canvas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit rayhit = new RaycastHit();

        if (Physics.Raycast(ray, out rayhit)){
            GameObject hitObject = rayhit.collider.gameObject;
            //AudioSource sound = hitObject.GetComponent<AudioSource>();

            canvas.SetActive(true);
            UnityEngine.UI.Button btn = UnityEngine.UI.Button.FindWithTag("button");

            btn.onClick.AddListener(delegate() { 
                hitObject.GetComponent<AudioSource>().Play();
            });
        }
    }
}
