using CefSharp;

namespace v5yxBrowser {
    internal class SchemeHandlerFactory : ISchemeHandlerFactory
    {

        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {
            return new SchemeHandler(MainForm.Instance);
        }
    }
}