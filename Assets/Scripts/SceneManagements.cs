 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class SceneManagements : MonoBehaviour
 {
     public float delay = 440;
     public string NextScene= "ConverterScene";
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NextScene);
     }
 }