using System;
using System.Net;
using System.Linq;
using System.Reflection;
using System.Collections;

namespace DotNet.VkAPI.Core.Models
{
    public class Cookies
    {
        public Cookies()
        {
            CookieContainer = new CookieContainer();
        }

        public CookieContainer CookieContainer { get; }

        public void AddForm(Uri responseUri, CookieCollection cookieCollection)
        {
            foreach (var cookie in cookieCollection)            
                CookieContainer.Add(responseUri, cookie as Cookie);
            BugFixCookieDomain();
        }

        private void BugFixCookieDomain()
        {
            if (!(CookieContainer.GetType()
                    .GetRuntimeFields()
                    .FirstOrDefault(x => x.Name == "m_domainTable" || x.Name == "_domainTable")
                    ?.GetValue(obj: CookieContainer) is IDictionary table))            
                return;
            var keys = table.Keys.OfType<string>().ToList();
            table.Keys.OfType<string>().ToList().ForEach(_ =>
            {
                if (_[0] != '.')
                    return;
                string newKey = _.Remove(0, 1);
                if (keys.Any(__ => __ == newKey))
                    return;
                table[newKey] = table[_];
                keys.Add(newKey);
            });           
        }

    }
}
