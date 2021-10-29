using System;

namespace OnfidoLib
{
    public static class Settings
    {
        public static string _apiUrl;

        private static string _apiVersion;

        private static string _apiToken;

        public static string GetApiToken()
        {
            if (string.IsNullOrEmpty(_apiToken))
            {
                throw new Exception("Api Token is not set!");
            }

            if (string.IsNullOrEmpty(_apiVersion))
            {
                throw new Exception("Api version is not set!");
            }

            if (string.IsNullOrEmpty(_apiUrl))
            {
                throw new Exception("Api url is not set!");
            }

            return _apiToken;
        }

        public static void SetApiToken(string apiToken, string apiVersion, string apiUrl)
        {
            _apiToken = apiToken;
            _apiVersion = apiVersion;
            _apiUrl = apiUrl;
        }

        public static string GetApiVersion() => _apiVersion;

        public static string GetApiUrl() => _apiUrl;
    }
}
