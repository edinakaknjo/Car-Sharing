using Microsoft.Extensions.Logging;
using Firebase.Auth;
using Firebase.Auth.Providers;
using CarSharingN.ViewModels;
using CarSharingN.Views;
namespace CarSharingN
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyBpz9WFRDHPZtBL3-0dCvgl8CU4w6lajdY",
                AuthDomain = "carsharingn.firebaseapp.com",

                Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }
            }));
            builder.Services.AddTransient<RegisterViewModel>();
            builder.Services.AddTransient<RegisterPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<LoginPageView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
