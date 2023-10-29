using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Coin : MonoBehaviour
{
    private Player playerJumpScript;
    [SerializeField] private Text coincounter;
    private int coincollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpScript = GetComponent<Player>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Destroy(other.gameObject);
            coincollected++;
            if (coincollected >= 4)
            {
                SceneManager.LoadScene(1);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        coincounter.text = ("" + coincollected);


    }
}