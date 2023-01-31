string user = string.Empty, pass = string.Empty;
ServiceReferenceLogin.LoginServiceClient client = new ServiceReferenceLogin.LoginServiceClient();
Console.WriteLine("Insert user");
user = Console.ReadLine()!;
Console.WriteLine("Insert password");
pass = Console.ReadLine()!;
bool result = client.LoginAsync(user, pass).Result;
if(result){
    Console.WriteLine("Successful");
}else {
    Console.WriteLine("Login Error");
}
Console.ReadKey();