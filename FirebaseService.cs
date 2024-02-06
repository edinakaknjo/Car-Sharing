using System;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Auth.Providers;

public class FirebaseService
{
    private readonly FirebaseAuthProvider _authProvider;

    public FirebaseService()
    {
        _authProvider = new FirebaseAuthProvider(new FirebaseConfig("\r\nAIzaSyBpz9WFRDHPZtBL3-0dCvgl8CU4w6lajdY"));
    }

    public async Task<FirebaseAuthLink> LoginAsync(string email, string password)
    {
        return await _authProvider.SignInWithEmailAndPasswordAsync(email, password);
    }

    public async Task<FirebaseAuthLink> RegisterAsync(string email, string password)
    {
        return await _authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
    }

    public async Task LogoutAsync()
    {
        try
        {
            await _authProvider.SignOutAsync();
        }
        catch (Exception ex)
        {
            // Handle exceptions if needed
            Console.WriteLine($"Error during logout: {ex.Message}");
        }
    }
}
