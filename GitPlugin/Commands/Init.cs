﻿using System.IO;
using System.Linq;
using EnvDTE;

namespace GitPlugin.Commands
{
    public sealed class Init : ItemCommandBase
    {
        protected override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane)
        {
            if (string.IsNullOrEmpty(fileName) || Path.GetInvalidPathChars().Any(fileName.Contains))
                return;
            var directoryName = Path.GetDirectoryName(fileName);
            RunGitEx("init", directoryName);
        }

        protected override CommandTarget SupportedTargets
        {
            get { return CommandTarget.Any; }
        }
    }
}
