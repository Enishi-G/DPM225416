namespace Singleton.NetOptimized;

using System;
using System.Collections.Generic;

/// <summary>
/// The 'Singleton' class
/// </summary>
public sealed class LoadBalancer
{
    // Static members are 'eagerly initialized', that is, 
    // immediately when class is loaded for the first time.
    // .NET guarantees thread safety for static initialization
    private static readonly LoadBalancer instance = new();

    private readonly List<Server> servers;
    private readonly Random random = new();

    // Note: constructor is 'private'
    private LoadBalancer()
    {
        // Load list of available servers

        servers = [
                    new(Name: "ServerI", Ip: "120.14.220.18"),
                    new(Name: "ServerII", Ip: "120.14.220.19" ),
                    new(Name: "ServerIII", Ip: "120.14.220.20" ),
                    new(Name: "ServerIV", Ip: "120.14.220.21" ),
                    new(Name: "ServerV", Ip: "120.14.220.22" )
                  ];
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return instance;
    }

    // Simple, but effective load balancer
    public Server NextServer
    {
        get => servers[random.Next(servers.Count)];
    }
}
