﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharingN.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {

        private readonly FirebaseAuthClient _firebaseAuthClient;

        public RegisterViewModel(FirebaseAuthClient firebaseAuthClient)
        {

            _firebaseAuthClient = firebaseAuthClient;
        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _confirmPassword;

        [RelayCommand]
        private async Task Register()
        {
            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Password se ne podudara", "OK");
                return;
            }
            try
            {
                await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(Email, Password);
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Registrovali ste svoj profil", "OK");
                Email = string.Empty;
                Password = string.Empty;
                ConfirmPassword = string.Empty;
                await Shell.Current.GoToAsync("//LoginPageView");
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Pokušajte ponovo kasnije", "OK");
            }
        }


    }
}