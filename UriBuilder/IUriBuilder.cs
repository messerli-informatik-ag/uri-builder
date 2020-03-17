using System;

namespace Messerli.UriBuilder
{
    public interface IUriBuilder
    {
        IUriBuilder Path(string path);

        Uri Build();
    }
}
