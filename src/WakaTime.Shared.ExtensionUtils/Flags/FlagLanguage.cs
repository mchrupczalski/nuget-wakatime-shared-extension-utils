﻿namespace WakaTime.Shared.ExtensionUtils.Flags
{
    /// <summary>
    ///     Extension methods for managing [--language] flag.
    /// </summary>
    public static class FlagLanguage
    {
        #region Static Fields and Const

        private const string CliFlagName = "--language";
        private const string JsonFlagName = "language";

        #endregion

        /// <summary>
        ///     Adds [--language] flag to the CLI arguments.
        /// </summary>
        /// <param name="flagHolder">The <see cref="FlagHolder" /> instance.</param>
        /// <param name="value">Optional language name. If valid, takes priority over auto-detected language.</param>
        /// <seealso cref="FlagLanguageAlternate.AddFlagLanguageAlternate" />
        public static FlagHolder AddFlagLanguage(this FlagHolder flagHolder, string value)
        {
            flagHolder.AddFlag(new CliFlag<string>(CliFlagName, JsonFlagName, value));
            return flagHolder;
        }

        /// <summary>
        ///     Removes the [--language] flag from the CLI arguments.
        /// </summary>
        /// <param name="flagHolder">The <see cref="FlagHolder" /> instance.</param>
        /// <seealso cref="FlagLanguageAlternate.RemoveFlagLanguageAlternate" />
        public static FlagHolder RemoveFlagLanguage(this FlagHolder flagHolder)
        {
            flagHolder.RemoveFlag(CliFlagName);
            return flagHolder;
        }
    }
}