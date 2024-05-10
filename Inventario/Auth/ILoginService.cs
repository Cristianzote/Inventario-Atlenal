namespace Inventario.Auth
{
    internal interface ILoginService
    {
        public interface ILoginService
        {
            Task LoginAsync(string token);

            Task LogoutAsync();
        }
    }
}
