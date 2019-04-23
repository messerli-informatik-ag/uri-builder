using System;
using System.Text;

namespace Update.Client.ServerCommunication.Rest
{
    public class RestServiceUriBuilder : IUriBuilder
    {
        private readonly Uri _root;
        private readonly StringBuilder _paths;

        public RestServiceUriBuilder(Uri root)
        {
            _root = root;
            _paths = new StringBuilder();
        }

        public IUriBuilder Path(string path)
        {
            var sanitizedPath = path.Trim('/');
            _paths.Append('/').Append(sanitizedPath);
            return this;
        }

        public Uri Build()
        {
            return new Uri(_root, _paths.ToString());
        }
    }
}