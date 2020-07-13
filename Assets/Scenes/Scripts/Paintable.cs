using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    [SerializeField]
    private GameObject brush;

    [SerializeField]
    private Material matBase;

    [SerializeField]
    private PainManager paintManager;

    [SerializeField]
    private float BrushSize = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                var go = Instantiate(brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * BrushSize;
                go.GetComponent<Renderer>().material = new Material(matBase);
                go.GetComponent<Renderer>().material.SetColor("_Color", paintManager.GetColor());
            }
        }
    }
}
