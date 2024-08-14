// <auto-generated/>
using KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula;
using KiotaPosts.Client.Api.Sep.Grupo.ValidarCedula;
using KiotaPosts.Client.Api.Sep.Grupo.ValidarCertificado;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.Api.Sep.Grupo
{
    /// <summary>
    /// Builds and executes requests for operations under \api\sep\grupo
    /// </summary>
    public class GrupoRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The obtenerCedula property</summary>
        public KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder ObtenerCedula
        {
            get => new KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validarCedula property</summary>
        public KiotaPosts.Client.Api.Sep.Grupo.ValidarCedula.ValidarCedulaRequestBuilder ValidarCedula
        {
            get => new KiotaPosts.Client.Api.Sep.Grupo.ValidarCedula.ValidarCedulaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validarCertificado property</summary>
        public KiotaPosts.Client.Api.Sep.Grupo.ValidarCertificado.ValidarCertificadoRequestBuilder ValidarCertificado
        {
            get => new KiotaPosts.Client.Api.Sep.Grupo.ValidarCertificado.ValidarCertificadoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sep.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sep/grupo", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sep.Grupo.GrupoRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GrupoRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sep/grupo", rawUrl)
        {
        }
    }
}
