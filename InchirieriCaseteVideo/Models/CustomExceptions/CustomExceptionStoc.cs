﻿using System;
using System.Runtime.Serialization;

namespace InchirieriCaseteVideo.Models
{
    class CustomExceptionStoc : Exception
    {
        public override string Message {
            get
            {
                return "Stocul trebuie sa fie un numar mai mare sau egal cu 0!";
            }
        }
    }
}