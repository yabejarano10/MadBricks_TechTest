using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager:MonoBehaviour
{
    [SerializeField]
    private GameObject[] stars;

    [SerializeField]
    private Canvas gameCanvas;

    [SerializeField]
    private Canvas endCanvas;

    IEnumerator ShowEndCanvas()
    {
        gameCanvas.gameObject.SetActive(false);
        endCanvas.gameObject.SetActive(true);

        stars[0].SetActive(true);
        stars[0].GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.0f);
        stars[1].SetActive(true);
        stars[1].GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.0f);
        stars[2].SetActive(true);
        stars[2].GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1.0f);
        GetComponent<AudioSource>().Play();
    }

    public void WinGame()
    {
        StartCoroutine(ShowEndCanvas());
    }

    void Start()
    {

    }
    void Update()
    {

    }
}
