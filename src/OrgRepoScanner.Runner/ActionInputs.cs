﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgRepoScanner.Runner
{
    public class ActionInputs
    {
        [Option('o', "org", Required = true, HelpText = "The name of the github organization.")]
        public string OrganizationName { get; set; }

        [Option('t', "token", Required = true, HelpText = "The github token for calling github API.")]
        public string GithubToken { get; set; }

        [Option('k', "kind", Required = true, HelpText = "The type of pipeline.")]
        public string PipelineKind { get; set; }

        [Option('u', "sonar-token", Required = true, HelpText = "Token for sonar cloud")]
        public string SonarToken { get; set; }

        [Option('a', "sonar-url", Required = true, HelpText = "Api URL for sonar cloud")]
        public string SonarApiUrl { get; set; }

        [Option('s', "sonar-org", Required = true, HelpText = "Org Key for sonar cloud")]
        public string SonarOrgKey { get; set; }

        [Option('f', "sonar-format", Required = true, HelpText = "Project key format for sonar cloud")]
        public string SonarProjectKeyFormat { get; set; }
        [Option('m', "md-file", Required = true, HelpText = "Name of markdown file")]
        public string MarkdownFileName { get; set; }

    }
}
