using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int count;

    public bool answer;

    public bool canTell;
   
    private void Update()
    {
        if (GameManager.Instance.error >= 3)
            return;
        if (transform.position.x > 8 && canTell)
        {
            Debug.Log("�չ�");
            canTell = false;
            if (GameManager.Instance.isback)
            {
                if (!GameManager.Instance.answer)
                {
                    GameManager.Instance.exit++;
                    GameManager.Instance.error = 0;
                }
                else
                {
                    GameManager.Instance.exit = 0;
                    GameManager.Instance.error++;
                }
                    
                
                Debug.Log("��");

            }
            else if (!GameManager.Instance.isback)
            {

                if (GameManager.Instance.answer)
                {
                    GameManager.Instance.exit++;
                    GameManager.Instance.error = 0;
                }
                else
                {
                    GameManager.Instance.exit = 0;
                    GameManager.Instance.error++;
                }
                    
                Debug.Log("��");


            }

            GameManager.Instance.CHRoom();
            transform.position += new Vector3(-16f, 0, 0);
            GameManager.Instance.isback = false;
            //Invoke("RoadTell", 0.5f);


        }
        if (transform.position.x < -8 && canTell)
        {
            canTell = false;
            Debug.Log("�޹�");
            if (GameManager.Instance.isback)
            {
                if (GameManager.Instance.answer)
                {
                    GameManager.Instance.exit++;
                    GameManager.Instance.error = 0;
                } 
                else
                {
                    GameManager.Instance.exit = 0;
                    GameManager.Instance.error++;

                }
                    
                Debug.Log("��");


            }
            else if (!GameManager.Instance.isback)
            {
                if (!GameManager.Instance.answer)
                {
                    GameManager.Instance.exit++;
                    GameManager.Instance.error = 0;
                }
                else
                {
                    GameManager.Instance.exit = 0;
                    GameManager.Instance.error++;
                }
                   
                Debug.Log("�ڷ�");


            }
            GameManager.Instance.isback = true;
            GameManager.Instance.CHRoom();
            transform.position += new Vector3(16f, 0, 0);
            //Invoke("RoadTell", 0.5f);

        }
    }

    void RoadTell()
    {
        canTell = true;
    }
}

   
