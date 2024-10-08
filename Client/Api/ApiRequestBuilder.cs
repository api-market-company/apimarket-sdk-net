// <auto-generated/>
using KiotaPosts.Client.Api.Ai;
using KiotaPosts.Client.Api.Balance;
using KiotaPosts.Client.Api.Imss;
using KiotaPosts.Client.Api.Infonavit;
using KiotaPosts.Client.Api.Renapo;
using KiotaPosts.Client.Api.Sat;
using KiotaPosts.Client.Api.Sep;
using KiotaPosts.Client.Api.V2;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api
{
    /// <summary>
    /// Builds and executes requests for operations under \api
    /// </summary>
    public class ApiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ai property</summary>
        public KiotaPosts.Client.Api.Ai.AiRequestBuilder Ai
        {
            get => new KiotaPosts.Client.Api.Ai.AiRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The balance property</summary>
        public KiotaPosts.Client.Api.Balance.BalanceRequestBuilder Balance
        {
            get => new KiotaPosts.Client.Api.Balance.BalanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The imss property</summary>
        public KiotaPosts.Client.Api.Imss.ImssRequestBuilder Imss
        {
            get => new KiotaPosts.Client.Api.Imss.ImssRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The infonavit property</summary>
        public KiotaPosts.Client.Api.Infonavit.InfonavitRequestBuilder Infonavit
        {
            get => new KiotaPosts.Client.Api.Infonavit.InfonavitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The renapo property</summary>
        public KiotaPosts.Client.Api.Renapo.RenapoRequestBuilder Renapo
        {
            get => new KiotaPosts.Client.Api.Renapo.RenapoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sat property</summary>
        public KiotaPosts.Client.Api.Sat.SatRequestBuilder Sat
        {
            get => new KiotaPosts.Client.Api.Sat.SatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sep property</summary>
        public KiotaPosts.Client.Api.Sep.SepRequestBuilder Sep
        {
            get => new KiotaPosts.Client.Api.Sep.SepRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The v2 property</summary>
        public KiotaPosts.Client.Api.V2.V2RequestBuilder V2
        {
            get => new KiotaPosts.Client.Api.V2.V2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", rawUrl)
        {
        }
    }
}
