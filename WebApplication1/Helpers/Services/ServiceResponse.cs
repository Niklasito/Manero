using Manero.Enums;

namespace Manero.Helpers.Services
{
    public class ServiceResponse<T>
    {
        public StatusCode StatusCode { get; set; }

        public T? Content { get; set; }
    }
}
