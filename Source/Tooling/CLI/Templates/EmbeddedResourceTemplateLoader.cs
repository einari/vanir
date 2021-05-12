// Copyright (c) Dolittle. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Dolittle.Vanir.CLI.Templates
{
    public class EmbeddedResourceTemplateLoader : ITemplateLoader
    {
        public bool Exists(string templateName)
        {
            return true;
        }

        public string Load(string templateName)
        {
            return string.Empty;
        }
    }
}
