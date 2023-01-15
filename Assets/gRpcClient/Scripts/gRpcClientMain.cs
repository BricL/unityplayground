using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Grpc.Core;
using GrpcGreeterClient;

public class gRpcClientMain : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var channel = new Channel("http://localhost:5050", ChannelCredentials.Insecure);
        var client = new Greeter.GreeterClient(channel);
        var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

        Debug.Log("Greeting: " + reply.Message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
