using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW request = new WWW("http://localhost/Tamagochi/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
        UnityEngine.Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *= 2;
        UnityEngine.Debug.Log(webNumber);
    }

}
