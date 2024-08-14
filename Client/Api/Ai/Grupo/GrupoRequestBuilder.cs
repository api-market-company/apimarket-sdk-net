// <auto-generated/>
using KiotaPosts.Client.Api.Ai.Grupo.ProcesamientoMasivo;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api.Ai.Grupo
{
    /// <summary>
    /// Builds and executes requests for operations under \api\ai\grupo
    /// </summary>
    public class GrupoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The procesamientoMasivo property</summary>
        public KiotaPosts.Client.Api.Ai.Grupo.ProcesamientoMasivo.ProcesamientoMasivoRequestBuilder ProcesamientoMasivo
        {
            get => new KiotaPosts.Client.Api.Ai.Grupo.ProcesamientoMasivo.ProcesamientoMasivoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Ai.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/ai/grupo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Ai.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/ai/grupo", rawUrl)
        {
        }
    }
}
