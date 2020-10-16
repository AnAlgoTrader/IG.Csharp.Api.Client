namespace IG.Csharp.Api.Client.Rest.Request
{
    public class AuthenticationRequest
    {
        ///<Summary>
        ///Client login identifier
        ///</Summary>
        public string identifier { get; set; }
        ///<Summary>
        ///Client login password
        ///</Summary>
        public string password { get; set; }
        ///<Summary>
        ///Whether the password has been sent encrypted.
        ///</Summary>
        public bool encryptedPassword { get; set; }
    }
}
