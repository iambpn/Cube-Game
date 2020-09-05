using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text lvl = this.GetComponent<Text>();
        lvl.text = SceneManager.GetActiveScene().name;
    }
}
