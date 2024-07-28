using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using UnityEngine;
usign Fi
public class WriteToS3 : MonoBehaviour
{
    // Start is called before the first frame update
    public IAmazonS3 s3Client;
    
    string jsonPath = "secrets.json";
    
    void Start()
    {
        // debug log the current path
        Debug.Log(Application.persistentDataPath);
        
        
        AmazonS3Config s3Config = new AmazonS3Config();
        s3Config.RegionEndpoint = Amazon.RegionEndpoint.USEast2;
        
        // Building S3 client with Access Key and Secret Access Key
        s3Client = new AmazonS3Client("AKIAUUCCXU7QHL2TK37P", "lXu3H7vuoi9krlVQ8LpaPDJCmEXvnhOh56t1U3tT", s3Config);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
