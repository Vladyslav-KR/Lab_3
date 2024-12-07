BaseConsole.Initialize();

Network network = new Network();

Server server = new Server("192.168.0.1", "Linux", 3.5, 2000);
Workstation workstation = new Workstation("192.168.0.2", "Windows", 2.5, "User A");
Router router = new Router("192.168.0.3", "CiscoOS", 1.2, 50);

network.AddDevice(server);
network.AddDevice(workstation);
network.AddDevice(router);

network.DisplayDevices();

server.Connect(workstation);
server.SendData("Hello, Workstation!", workstation);
workstation.ReceiveData("Hello, Workstation!");
server.Disconnect(workstation);
