// <auto-generated/>
using KiotaPosts.Client.Api.Renapo.Grupo.ObtenerCurp;
using KiotaPosts.Client.Api.Renapo.Grupo.ValidaCurp;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api.Renapo.Grupo
{
    /// <summary>
    /// Builds and executes requests for operations under \api\renapo\grupo
    /// </summary>
    public class GrupoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The obtenerCurp property</summary>
        public KiotaPosts.Client.Api.Renapo.Grupo.ObtenerCurp.ObtenerCurpRequestBuilder ObtenerCurp
        {
            get => new KiotaPosts.Client.Api.Renapo.Grupo.ObtenerCurp.ObtenerCurpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validaCurp property</summary>
        public KiotaPosts.Client.Api.Renapo.Grupo.ValidaCurp.ValidaCurpRequestBuilder ValidaCurp
        {
            get => new KiotaPosts.Client.Api.Renapo.Grupo.ValidaCurp.ValidaCurpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Renapo.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/renapo/grupo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Renapo.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/renapo/grupo", rawUrl)
        {
        }
    }
}
