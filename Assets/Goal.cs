using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject NextStageUI;
    public GameObject RETRYUI;
    public GameObject GAMECLEARUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");
        NextStageUI.SetActive(true);
        RETRYUI.SetActive(true);
        GAMECLEARUI.SetActive(true);
    }

}
