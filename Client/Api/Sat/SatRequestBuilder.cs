// <auto-generated/>
using KiotaPosts.Client.Api.Sat.Grupo;
using KiotaPosts.Client.Api.Sat.V2;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api.Sat
{
    /// <summary>
    /// Builds and executes requests for operations under \api\sat
    /// </summary>
    public class SatRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The grupo property</summary>
        public KiotaPosts.Client.Api.Sat.Grupo.GrupoRequestBuilder Grupo
        {
            get => new KiotaPosts.Client.Api.Sat.Grupo.GrupoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The v2 property</summary>
        public KiotaPosts.Client.Api.Sat.V2.V2RequestBuilder V2
        {
            get => new KiotaPosts.Client.Api.Sat.V2.V2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.SatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sat", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.SatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sat", rawUrl)
        {
        }
    }
}
