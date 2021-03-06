﻿using System;
using GenerationStudio.Attributes;

namespace GenerationStudio.Elements
{
    [Serializable]
    [ElementName("Tables")]
    [ElementIcon("GenerationStudio.Images.Folder.gif")]
    public class TablesElement : StaticElement
    {
        public override string GetDisplayName()
        {
            return "Tables";
        }
    }
}