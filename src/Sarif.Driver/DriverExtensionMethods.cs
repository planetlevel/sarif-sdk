﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.using System;

using System;
using Microsoft.CodeAnalysis.Sarif.Writers;

namespace Microsoft.CodeAnalysis.Sarif.Driver
{
    public static class DriverExtensionMethods
    {
        public static LoggingOptions ConvertToLoggingOptions(this AnalyzeOptionsBase analyzeOptions)
        {
            LoggingOptions loggingOptions = LoggingOptions.None;

            if (analyzeOptions.Verbose) { loggingOptions |= LoggingOptions.Verbose; }
            if (analyzeOptions.PrettyPrint) { loggingOptions |= LoggingOptions.PrettyPrint; }
            if (analyzeOptions.LogEnvironment) { loggingOptions |= LoggingOptions.PersistEnvironment; }
            if (analyzeOptions.ComputeFileHashes) { loggingOptions |= LoggingOptions.ComputeFileHashes; }
            if (analyzeOptions.PersistFileContents) { loggingOptions |= LoggingOptions.PersistFileContents; }

            return loggingOptions;
        }
    }
}
