﻿using GServer.Models.Artifacts.Artifact;
using GServer.Models.Artifacts.Interfaces;

namespace GServer.Models.Artifacts
{
    public class InvisibilityRingArtifact : ArtifactBase, IArtifactItem
    {
        public InvisibilityRingArtifact()
        {
            Name = "Кольцо невидимости";
            ArtifactType = ArtifactType.InvisibilityRingArtifact;
            Description = "";
            IsCanByUsed = true;
        }

        public string UseArtifact()
        {
            ArtifactStorage.ArtifactStorage.AddUsedArtifact(this);

            string str = "";

            if (this.IsCanByUsed)
                str = $"Артефакт {this.Name}: использован";
            else
                str = $"Артефакт {this.Name}: невозможно использовать";
            return str;

        }


    }
}
