using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class APITest : MonoBehaviour
{
    private string apiUrl = "http://localhost:8080/api/test";

    void Start()
    {
        StartCoroutine(TestConnection());
    }

    private IEnumerator TestConnection()
    {
        UnityWebRequest request = UnityWebRequest.Get(apiUrl);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Réponse de l'API : " + request.downloadHandler.text);
        }
        else
        {
            Debug.LogError("Erreur : " + request.error);
        }
    }
}
