namespace PublisherService.Utilities
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

        /// <summary>
        /// Opens a HTTP listener for a WCF/Web Service
        /// </summary>
        /// <typeparam name="TServiceContract"></typeparam>
        /// <remarks>
        /// This is a self hosted HTTP server.  There is no need to install MS Internet Information Server (IIS).
        /// </remarks>
        public class WcfHttpListener<TServiceContract>
        {
            private ServiceHost _host;

            public WcfHttpListener()
            {
                Path = typeof(TServiceContract).Name;
            }

            public int PortNumber { private get; set; }

            public string Path { private get; set; }

            public string Address => "http://localhost:" + PortNumber + "/" + Path;

            public string MetadataExchangeAddress => Address + "/mex";

            /// <summary>
            /// Will add an endpoint that can be used by clients to "Add Service Reference" to their project.
            /// Exposed as Address &amp; "/mex" or Address &amp; "?wsdl".
            /// </summary>
            /// <value></value>
            /// <returns></returns>
            /// <remarks></remarks>
            public bool ExposeMetadata { get; set; }

            public void Open(TServiceContract server)
            {
                _host = new ServiceHost(server, new Uri(Address));

                var behaviour = _host.Description.Behaviors.Find<ServiceBehaviorAttribute>();
                behaviour.InstanceContextMode = InstanceContextMode.Single;
                //behaviour.IncludeExceptionDetailInFaults = true;

                var binding = new BasicHttpBinding { Namespace = behaviour.Namespace };
                _host.AddServiceEndpoint(typeof(TServiceContract), binding, string.Empty);

                var sdb = _host.Description.Behaviors.Find<ServiceDebugBehavior>();
                sdb.HttpHelpPageEnabled = false;

                if (ExposeMetadata)
                {
                    AddMetadataEndpoint(_host);
                }

                _host.Open();
            }


            private static ServiceMetadataBehavior GetBehaviour(ServiceHostBase host)
            {
                return host.Description.Behaviors.Find<ServiceMetadataBehavior>() ?? new ServiceMetadataBehavior();
            }

            private void AddMetadataEndpoint(ServiceHostBase host)
            {
                var behaviour = GetBehaviour(host);

                behaviour.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                behaviour.HttpGetEnabled = true;
                host.Description.Behaviors.Add(behaviour);

                host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), MetadataExchangeAddress);
            }


            public void Close()
            {
                _host.Close();
            }

        }
    }

