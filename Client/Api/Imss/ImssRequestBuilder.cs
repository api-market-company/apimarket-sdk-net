// <auto-generated/>
using KiotaPosts.Client.Api.Imss.Grupo;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api.Imss
{
    /// <summary>
    /// Builds and executes requests for operations under \api\imss
    /// </summary>
    public class ImssRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The grupo property</summary>
        public KiotaPosts.Client.Api.Imss.Grupo.GrupoRequestBuilder Grupo
        {
            get => new KiotaPosts.Client.Api.Imss.Grupo.GrupoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.ImssRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImssRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.ImssRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ImssRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss", rawUrl)
        {
        }
    }
}
