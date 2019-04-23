using System;

namespace UriBuilder
{
    public interface IUriBuilder
    {
        IUriBuilder Path(string path);

        Uri Build();
    }
}