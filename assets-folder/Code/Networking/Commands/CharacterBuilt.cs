﻿using UnityEngine;
using System.Collections;
using System;

namespace LlapiExample
{
    public class CharacterBuilt : BaseCommand, ICommand
    {
        public Vector3 position;
        public float size;

        public CharacterBuilt() : base(CommandIds.Character_Built)
        {

        }

        public object[] Data()
        {
            return new object[] {
                position,
                size
            };
        }

        public void Read(object[] buffer, ref int position)
        {
            this.position = (Vector3)buffer[++position];
            size = (float)buffer[++position];
        }
    }
}