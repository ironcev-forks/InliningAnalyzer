﻿using InliningAnalyzer;
using System.Threading.Tasks;

namespace VsExtension.Common
{
    public interface IProjectPropertyProvider
    {
        Task LoadProperties();
        bool IsOptimized { get; }
        bool Prefer32Bit { get; }
        string PlatformTarget { get; }
        string ProjectPath { get; }
        string OutputPath { get; }
        string GetOutputFilename(string publishPath);
        TargetRuntime TargetRuntime { get; }
        string TargetFramework { get; }
        bool IsWebSdkProject { get; }
    }
}
