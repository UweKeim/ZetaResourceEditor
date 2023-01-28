namespace UpdateChecker.Code;

using System;
using System.Configuration;
using System.Web.Services;

public class ApiKeyProtectedWebServiceBase :
    WebService
{
    private static string referenceApiKey => ConfigurationManager.AppSettings[@"wsApiKey"];

    protected void CheckThrowApiKey(
        string apiKey)
    {
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new ArgumentException(
                Resources.Resources.ApiKeyProtectedWebServiceBase_CheckThrowApiKey_API_key_cannot_be_NULL_or_empty_,
                nameof(apiKey));
        }
        else if (string.Compare(apiKey, referenceApiKey, StringComparison.OrdinalIgnoreCase) != 0)
        {
            throw new("Invalid API key.");
        }
    }
}