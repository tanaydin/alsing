﻿using System;
using GenerationStudio.Attributes;

namespace GenerationStudio.Elements
{
    [Serializable]
    [ElementName("Views")]
    [ElementIcon("GenerationStudio.Images.Folder.gif")]
    public class ViewsElement : StaticElement
    {
        public override string GetDisplayName()
        {
            return "Views";
        }
    }
}