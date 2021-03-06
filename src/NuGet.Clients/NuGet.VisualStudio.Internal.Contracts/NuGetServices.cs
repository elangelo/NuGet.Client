// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.ServiceHub.Framework;

namespace NuGet.VisualStudio.Internal.Contracts
{
    public static class NuGetServices
    {
        public static string NuGetSolutionServiceName = "NuGetSolutionService";
        public static string NuGetSolutionServiceVersion = "1.0.0";
        /// <summary>
        /// A service descriptor for the NuGetSolutionService service. 
        /// </summary>
        public static ServiceRpcDescriptor NuGetSolutionService = new ServiceJsonRpcDescriptor(
          new ServiceMoniker(NuGetSolutionServiceName, new Version(NuGetSolutionServiceVersion)),
          ServiceJsonRpcDescriptor.Formatters.UTF8,
          ServiceJsonRpcDescriptor.MessageDelimiters.HttpLikeHeaders);
    }
}
