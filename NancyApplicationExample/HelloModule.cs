using Nancy;
using Newtonsoft.Json;

namespace NancyApplicationExample
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/hello/{name}"] = parameters =>
                {
                    var message = string.Format("Hello {0}", parameters.name);
                    return JsonConvert.SerializeObject(message);
                };

            Get["/goodbye/{name?}"] = parameters =>
                {
                    if (string.IsNullOrEmpty(parameters.name))
                        return string.Format("Bye bye chiunque voi siate");
                    return string.Format("Bye bye {0}", parameters.name);
                };
        }
    }
}