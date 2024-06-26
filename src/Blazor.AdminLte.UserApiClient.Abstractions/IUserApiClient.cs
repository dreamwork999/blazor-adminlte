﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

using Blazor.AdminLte.Security.Abstractions.Models.Accounts;

namespace Blazor.AdminLte
{
    public interface IUserApiClient
    {
        string BaseUrl { get; set; }
        bool ReadResponseAsString { get; set; }
        Task<CaptchaGenerateResponse> CaptchaAsync();
        Task<ICollection<AccountResponse>> AccountsAllAsync();
        Task<ICollection<AccountResponse>> AccountsAllAsync(CancellationToken cancellationToken);
        Task AccountsDELETEAsync(int id);
        Task AccountsDELETEAsync(int id, CancellationToken cancellationToken);
        Task<AccountResponse> AccountsGETAsync(int id);
        Task<AccountResponse> AccountsGETAsync(int id, CancellationToken cancellationToken);
        Task<AccountResponse> AccountsPOSTAsync(CreateRequest body);
        Task<AccountResponse> AccountsPOSTAsync(CreateRequest body, CancellationToken cancellationToken);
        Task<AccountResponse> AccountsPUTAsync(int id, UpdateRequest body);
        Task<AccountResponse> AccountsPUTAsync(int id, UpdateRequest body, CancellationToken cancellationToken);
        Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest body);
        Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest body, CancellationToken cancellationToken);
        Task ForgotPasswordAsync(ForgotPasswordRequest body);
        Task ForgotPasswordAsync(ForgotPasswordRequest body, CancellationToken cancellationToken);
        Task<AuthenticateResponse> RefreshTokenAsync();
        Task<AuthenticateResponse> RefreshTokenAsync(CancellationToken cancellationToken);
        Task RegisterAsync(RegisterRequest body);
        Task RegisterAsync(RegisterRequest body, CancellationToken cancellationToken);
        Task ResetPasswordAsync(ResetPasswordRequest body);
        Task ResetPasswordAsync(ResetPasswordRequest body, CancellationToken cancellationToken);
        Task RevokeTokenAsync(RevokeTokenRequest body);
        Task RevokeTokenAsync(RevokeTokenRequest body, CancellationToken cancellationToken);
        Task ValidateResetTokenAsync(ValidateResetTokenRequest body);
        Task ValidateResetTokenAsync(ValidateResetTokenRequest body, CancellationToken cancellationToken);
        Task VerifyEmailAsync(VerifyEmailRequest body);
        Task VerifyEmailAsync(VerifyEmailRequest body, CancellationToken cancellationToken);
    }
}