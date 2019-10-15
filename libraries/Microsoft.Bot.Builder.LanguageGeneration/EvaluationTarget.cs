﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Microsoft.Bot.Expressions;

namespace Microsoft.Bot.Builder.LanguageGeneration
{
    internal class EvaluationTarget
    {
        public EvaluationTarget(string templateName, object scope)
        {
            TemplateName = templateName;
            Scope = scope;
        }

        public Dictionary<string, object> EvaluatedChildren { get; set; } = new Dictionary<string, object>();

        public string TemplateName { get; set; }

        public object Scope { get; set; }

        public string GetId()
        {
            return TemplateName + Scope?.ToString();
        }
    }
}
