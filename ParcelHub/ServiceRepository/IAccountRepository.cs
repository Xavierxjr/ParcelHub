﻿using Microsoft.AspNetCore.Identity;
using ParcelHub.Models;
using System.Threading.Tasks;

namespace ParcelHub.ServiceRepository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(InValidUser invalidUser);
        Task<SignInResult> PasswordSignInAsync(LoginUser loginUser);
        Task SignOutAsync();
    }
}