using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDissapear : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    public GameObject txt;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
            score++;
            if(txt != null){
                txt.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
            }
        }
    }
}