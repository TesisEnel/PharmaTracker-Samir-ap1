using PharmaTracker.Shared;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace PharmaTracker.Client.Extensions
{
    public class AuthenticacionExtension : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorage;
        private ClaimsPrincipal _noInformation = new ClaimsPrincipal(new ClaimsIdentity());

        public AuthenticacionExtension(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public async Task UpdateStatusAuthentication(SesionDTO? userSession)
        {
            ClaimsPrincipal claimsPrincipal;

            if (userSession != null)
            {
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userSession.Nombre),
                    new Claim(ClaimTypes.Email, userSession.Correo),
                    new Claim(ClaimTypes.Role, userSession.Rol),
                },"JwtAuth"));

                await _sessionStorage.SaveStorage("userSession", userSession);
            }
            else
            {
                claimsPrincipal = _noInformation;
                await _sessionStorage.RemoveItemAsync("userSession");
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));

        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userSession = await _sessionStorage.GetStorage<SesionDTO>("userSession");

            if (userSession == null)
                return await Task.FromResult(new AuthenticationState(_noInformation));
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new Claim(ClaimTypes.Name, userSession.Nombre),
                new Claim(ClaimTypes.Email, userSession.Correo),
                new Claim(ClaimTypes.Role, userSession.Rol),
            },"JwtAuth"));

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }   
    }
}
