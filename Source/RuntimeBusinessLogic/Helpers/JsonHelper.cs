namespace ZetaResourceEditor.RuntimeBusinessLogic.Helpers;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static class JsonHelper
{
    public static bool IsValidJson(string strInput)
    {
        strInput = strInput.Trim();
        if (strInput.StartsWith("{") && strInput.EndsWith("}") || //For object
            strInput.StartsWith("[") && strInput.EndsWith("]")) //For array
        {
            try
            {
                JToken.Parse(strInput);
                return true;
            }
            catch (JsonReaderException jex)
            {
                //Exception in parsing json
                Console.WriteLine(jex.Message);
                return false;
            }
            catch (Exception ex) //some other exception
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}