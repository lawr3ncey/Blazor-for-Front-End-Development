using System;
using System.Threading.Tasks;

namespace EventEaseApp.Services
{
    /// <summary>
    /// Simple user session state for client-side Blazor to track current user info.
    /// Scoped or Singleton works in Blazor WASM; we'll register as scoped.
    /// </summary>
    public class UserSessionState
    {
        public bool IsAuthenticated { get; private set; } = false;
        public string? UserName { get; private set; }
        public string? Email { get; private set; }

        public event Action? OnChange;

        public void Login(string name, string email)
        {
            IsAuthenticated = true;
            UserName = name;
            Email = email;
            NotifyStateChanged();
        }

        public void Logout()
        {
            IsAuthenticated = false;
            UserName = null;
            Email = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
