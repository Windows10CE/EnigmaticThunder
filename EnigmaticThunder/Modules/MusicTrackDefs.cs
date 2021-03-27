﻿using EnigmaticThunder.Util;
using RoR2;
using RoR2.Skills;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace EnigmaticThunder.Modules
{
    public class MusicTrackDefs : Module
    {
        internal static ObservableCollection<MusicTrackDef> MusicTrackDefDefinitions = new ObservableCollection<MusicTrackDef>();
        public override void Load()
        {
            base.Load();
            //Meow (Waiting for something to happen?)
        }

        public static void Add(MusicTrackDef MusicTrackDef)
        {
            //Check if the SurvivorDef has already been added.
            if (MusicTrackDefDefinitions.Contains(MusicTrackDef))
            {
                LogCore.LogE(MusicTrackDef + " has already been added to the MusicTrackDef Catalog, please do not try to add the same MusicTrackDef twice.");
                return;
            }
            //If not, add it to our SurvivorDefinitions
            MusicTrackDefDefinitions.Add(MusicTrackDef);
        }

        public override void ModifyContentPack(ContentPack pack)
        {
            base.ModifyContentPack(pack);
            //Make a list of survivor defs (we'll be converting it to an array later)
            List<MusicTrackDef> defs = new List<MusicTrackDef>();
            //Add everything from SurvivorDefinitions to it.
            foreach (MusicTrackDef def in MusicTrackDefDefinitions)
            {
                defs.Add(def);
            }
            //Convert the list into an array and give it to the ContentPack.
            pack.musicTrackDefs = defs.ToArray();
        }
    }
}