﻿using System;
using FlubuCore.Scripting.Analysis;

namespace FlubuCore.Scripting.Processors
{
    public class ClassDirectiveProcessor : IDirectiveProcessor
    {
        public bool Process(AnalyserResult analyserResult, string line, int lineIndex)
        {
            var i = line.IndexOf("class", StringComparison.Ordinal);
            if (i < 0)
                return false;

            var tmp = line.Substring(i + 6);
            tmp = tmp.TrimStart();
            i = tmp.IndexOf(" ", StringComparison.Ordinal);
            if (i == -1)
            {
                i = tmp.Length;
            }

            analyserResult.ClassName = tmp.Substring(0, i);
            return true;
        }
    }
}
