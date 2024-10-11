using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePort : MonoBehaviour
{

    public bool isYes;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!isYes)
            {
                GameManager.Instance.CHRoom();
                other.transform.position += new Vector3(-15f, 0, 0);
                if (GameManager.Instance.answer)
                    GameManager.Instance.exit++;




                
            }
            else if (isYes)
            {
                GameManager.Instance.CHRoom();
                other.transform.position += new Vector3(15f, 0, 0);
                if (!GameManager.Instance.answer)
                    GameManager.Instance.exit++;
            }

        }
    }
}
