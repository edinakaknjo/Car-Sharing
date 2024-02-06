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
    public partial class LoginViewModel : ObservableObject
    {
        private readonly FirebaseAuthClient _firebaseAuthClient;

        public LoginViewModel(FirebaseAuthClient firebaseAuthClient)
        {
            _firebaseAuthClient = firebaseAuthClient;

        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private async Task Login()
        {

            try
            {
                await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(Email, Password);
                await Application.Current.MainPage.DisplayAlert("Uspješno", "Prijavili ste se", "OK");
                Email = string.Empty;
                Password = string.Empty;
                await Shell.Current.GoToAsync("//HomePage");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"{e}", "OK");
            }
        }
    }
}