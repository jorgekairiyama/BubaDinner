using System.Net;

namespace BuberDinner.Application.Common.Errors
{
    public interface IServiceException
    {
        string ErrorMessage { get; }
        HttpStatusCode StatusCode { get; }
    }
}