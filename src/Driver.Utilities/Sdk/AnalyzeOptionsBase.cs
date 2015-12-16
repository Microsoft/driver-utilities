﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

using CommandLine;

namespace Microsoft.CodeAnalysis.Driver.Sdk
{
    [Verb("analyze", HelpText = "Analyze one or more targets for security and correctness issues.")]
    internal class AnalyzeOptions
    {
        [Value(0,
               HelpText = "One or more specifiers to a file, directory, or filter pattern that resolves to one or more targets to analyze.")]
        public IEnumerable<string> TargetFileSpecifiers { get; internal set; }

        [Option(
            'o',
            "output",
            HelpText = "File path to which analysis output will be written.")]
        public string OutputFilePath { get; internal set; }

        [Option(
            'v',
            "verbose",
            HelpText = "Emit verbose output. The resulting comprehensive report is designed to provide appropriate evidence for compliance scenarios.")]
        public bool Verbose { get; internal set; }

        [Option(
            'r',
            "recurse",
            HelpText = "Recurse into subdirectories when evaluating file specifier arguments.")]
        public bool Recurse { get; internal set; }

        [Option(
            'c',
            "config",
            HelpText = "Path to policy file that will be used to configure analysis. Pass value of 'default' to use built-in settings.")]
        public string ConfigurationFilePath { get; internal set; }

        [Option(
            's',
            "statistics",
            HelpText = "Generate timing and other statistics for analysis session.")]
        public bool Statistics { get; internal set; }

        [Option(
            'h',
            "hashes",
            HelpText = "Output SHA-256 hash of analysis targets when emitting SARIF reports.")]
        public bool ComputeTargetsHash { get; internal set; }

        [Option(
            "sympath",
            HelpText = "Symbols path value, e.g., SRV*http://msdl.microsoft.com/download/symbols or Cache*d:\\symbols;Srv**http://symweb")]
        public string SymbolsPath { get; internal set; }

        [Option(
            'p',
            "plug-in",
            Separator = ';',
            HelpText = "Path to plug-in that will be invoked against all targets in the analysis set.")]
        public IList<string> PlugInFilePaths { get; internal set; }
    }
}