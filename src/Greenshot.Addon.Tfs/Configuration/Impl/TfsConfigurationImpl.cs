﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

using System;
using Dapplo.Config.Ini;
using Greenshot.Core.Enums;

namespace Greenshot.Addon.Tfs.Configuration.Impl
{
    internal class TfsConfigurationImpl : IniSectionBase<ITfsConfiguration>, ITfsConfiguration
    {
        #region Implementation of IFileConfiguration

        public string OutputFilePath { get; set; }
        public bool OutputFileAllowOverwrite { get; set; }
        public string OutputFileFilenamePattern { get; set; }
        public OutputFormats OutputFileFormat { get; set; }
        public bool OutputFileReduceColors { get; set; }
        public bool OutputFileAutoReduceColors { get; set; }
        public int OutputFileReduceColorsTo { get; set; }
        public int OutputFileJpegQuality { get; set; }
        public bool OutputFilePromptQuality { get; set; }
        public uint OutputFileIncrementingNumber { get; set; }
        public string OptimizePNGCommand { get; set; }
        public string OptimizePNGCommandArguments { get; set; }

        #endregion

        #region Implementation of IDestinationFileConfiguration

        public bool UseOwnSettings { get; set; }

        #endregion

        #region Implementation of ITfsConfiguration

        public bool AfterUploadLinkToClipBoard { get; set; }
        public Uri TfsUri { get; set; }
        public string ApiKey { get; set; }

        #endregion
    }
}
