namespace Media2A.WebApp
{
    public partial class WebApp_AppModels
    {
        public partial class RequestHandler
        {
            public enum RoutingTypes
            {
                REDIRECT,
                PAGE,
                COMPONENT,
                COMPONENT_API,
                EXTERNAL,
            }
        }
    }
}