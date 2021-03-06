using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.RetryPolicies;
using System;
using System.IO;
using System.Threading.Tasks;
namespace Microsoft.WindowsAzure.Storage.Core.Executor
{
internal class RESTCommand<T> : StorageCommandBase<T>
{

    public Stream ResponseStream
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public Stream StreamToDispose
    {
        get; set;
    }

    public RESTCommand(StorageCredentials credentials, StorageUri storageUri)
      : this(credentials, storageUri, (UriQueryBuilder) null)
    {
        throw new System.NotImplementedException();
    }
    public RESTCommand(StorageCredentials credentials, StorageUri storageUri, UriQueryBuilder builder)
    {
        throw new System.NotImplementedException();
    }
}

}