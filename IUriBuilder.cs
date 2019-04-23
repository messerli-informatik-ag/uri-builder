using System;

namespace Update.Client.ServerCommunication
{
    public interface IServiceUriBuilder
    {
        IServiceUriBuilder Path(string path);

        Uri Build();
    }
}