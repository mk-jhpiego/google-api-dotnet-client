// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Groups Migration API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/google-apps/groups-migration/'>Groups Migration API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20140416 (0)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/google-apps/groups-migration/'>
 *              https://developers.google.com/google-apps/groups-migration/</a>
 *      <tr><th>Discovery Name<td>groupsmigration
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Groups Migration API can be found at
 * <a href='https://developers.google.com/google-apps/groups-migration/'>https://developers.google.com/google-apps/groups-migration/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.GroupsMigration.v1
{
    /// <summary>The GroupsMigration Service.</summary>
    public class GroupsMigrationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GroupsMigrationService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GroupsMigrationService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            archive = new ArchiveResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "groupsmigration"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/groups/v1/groups/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "groups/v1/groups/"; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Groups Migration API.</summary>
        public class Scope
        {
            /// <summary>Manage messages in groups on your domain</summary>
            public static string AppsGroupsMigration = "https://www.googleapis.com/auth/apps.groups.migration";

        }



        private readonly ArchiveResource archive;

        /// <summary>Gets the Archive resource.</summary>
        public virtual ArchiveResource Archive
        {
            get { return archive; }
        }
    }

    ///<summary>A base abstract class for GroupsMigration requests.</summary>
    public abstract class GroupsMigrationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new GroupsMigrationBaseServiceRequest instance.</summary>
        protected GroupsMigrationBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes GroupsMigration parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "archive" collection of methods.</summary>
    public class ArchiveResource
    {
        private const string Resource = "archive";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ArchiveResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Inserts a new mail into the archive of the Google group.</summary>
        /// <param name="groupId">The group ID</param>
        public virtual InsertRequest Insert(string groupId)
        {
            return new InsertRequest(service, groupId);
        }

        /// <summary>Inserts a new mail into the archive of the Google group.</summary>
        public class InsertRequest : GroupsMigrationBaseServiceRequest<Google.Apis.GroupsMigration.v1.Data.Groups>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, string groupId)
                : base(service)
            {
                GroupId = groupId;
                InitParameters();
            }


            /// <summary>The group ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "insert"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "{groupId}/archive"; }
            }

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts a new mail into the archive of the Google group.</summary>
        /// <param name="groupId">The group ID</param>
        /// <param name="stream">The stream to upload.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(string groupId, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, groupId, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.GroupsMigration.v1.Data.Groups>
        {

            /// <summary>Data format for the response.</summary>
            /// [default: json]
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AltEnum> Alt { get; set; }

            /// <summary>Data format for the response.</summary>
            public enum AltEnum
            {
                /// <summary>Responses with Content-Type of application/json</summary>
                [Google.Apis.Util.StringValueAttribute("json")]
                Json,
            }

            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields { get; set; }

            /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and
            /// reports. Required unless you provide an OAuth 2.0 token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Key { get; set; }

            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OauthToken { get; set; }

            /// <summary>Returns response with indentations and line breaks.</summary>
            /// [default: true]
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint { get; set; }

            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
            /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are
            /// provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
            /// limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp { get; set; }


            /// <summary>The group ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupId { get; private set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
            public InsertMediaUpload(Google.Apis.Services.IClientService service, string
             groupId, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "{groupId}/archive"), "POST", stream, contentType)
            {
                GroupId = groupId;
            }
        }
    }
}

namespace Google.Apis.GroupsMigration.v1.Data
{    

    /// <summary>JSON response template for groups migration API.</summary>
    public class Groups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of insert resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The status of the insert request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCode")]
        public virtual string ResponseCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}