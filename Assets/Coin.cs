using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //�܂��́u�Q�[���I�u�W�F�N�g�v��T���ĕϐ��ɍT���Ă���
        GameObject managerObject = GameObject.Find("GameManager");
        //�T���Ă������Q�[���I�u�W�F�N�g�ɑ΂���GetComponent��GameManager�R���|�[�l���g���擾
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }
}
