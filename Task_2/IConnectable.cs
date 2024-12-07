

public interface IConnectable
{
    void Connect(Computer device);   // Метод для підключення до іншого пристрою
    void Disconnect(Computer device); // Метод для відключення
    void SendData(string data, Computer device); // Метод для передачі даних
    void ReceiveData(string data);  // Метод для отримання даних
}
