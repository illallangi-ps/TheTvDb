using System;

using Microsoft.Win32;

namespace Illallangi.TheTvDb.Settings
{
    public static class RegistryKeyExtensions
    {
        public static string CreateSubKeyAndGetValue(this RegistryKey registryKey, string subkey, string name, string defaultValue = null)
        {
            var key = registryKey.CreateSubKey(subkey);
            var result = (key?.GetValue(name) ?? defaultValue ?? string.Empty).ToString();
            return string.IsNullOrEmpty(result) ? null : result;
        }

        public static void CreateSubKeyAndSetValue(this RegistryKey registryKey, string subkey, string name, string value)
        {
            var subKey = registryKey.CreateSubKey(subkey);
            if (subKey == null)
            {
                throw new NullReferenceException();
            }

            subKey.SetValue(name, value ?? string.Empty, RegistryValueKind.String);
        }
    }
}
