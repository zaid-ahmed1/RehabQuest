using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public bool task1Complete = false;
    public float timeToCompleteTask1 = 0f;
    public float totalTime = 0f;
    // public bool task2Complete = false;
    // public float timeToCompleteTask2 = 0f;
    public string name = "Player";
    public int age = 0;
    public int grade = 0;
    public string parent = "Parent";

    public WriteToS3 wts3;
    
    void OnApplicationQuit()
    {
        // Save data to file
        totalTime  = Timer.getTime();
        string data = JsonUtility.ToJson(this);
        string timestamp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        
        // Save data to local file
        System.IO.File.WriteAllText(Application.persistentDataPath  + "/"  + parent + "/" + name +"/" + timestamp +  ".json", data);
        // Save data to S3
        wts3.UploadFile(Application.persistentDataPath + "/"  + parent + "/" + name  + timestamp +  ".json",
            Application.persistentDataPath  + "/"  + parent + "/" + name +"/" + timestamp +  ".json");
        // Debug.Log(Application.persistentDataPath + "/player" + name + timestamp + ".json");

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
