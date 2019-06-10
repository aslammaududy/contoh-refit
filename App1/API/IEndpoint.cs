using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.API
{
    public interface IEndpoint
    {
        [Post("/post-login")]
        Task Login([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, string> loginInfo);
    }
}
